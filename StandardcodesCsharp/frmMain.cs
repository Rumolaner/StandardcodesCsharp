using SCCsharpSort;
using SCCsharpSearch;

namespace StandardcodesCsharp
{
    public partial class frmMain : Form
    {
        private static readonly NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

        public frmMain()
        {
            InitializeComponent();
        }

        private void btAutoFill_Click(object sender, EventArgs e)
        {
            string msg;
            if (!Int32.TryParse(tbWertelisteAnzahl.Text, out int anzahl))
            {
                msg = "Bei 'Werteliste Anzahl' bitte eine Zahl zwischen 1 und 100 eingeben";
                MessageBox.Show(msg);
            }
            else if (anzahl < 1 || anzahl > 100)
            {
                msg = "Bei 'Werteliste Anzahl' bitte eine Zahl zwischen 1 und 100 eingeben";
                MessageBox.Show(msg);
            }
            else if (!Int32.TryParse(tbWertelisteVon.Text, out int von))
            {
                msg = "Bei 'Werteliste Von' bitte eine Zahl eingeben";
                MessageBox.Show(msg);
            }
            else if (!Int32.TryParse(tbWertelisteBis.Text, out int bis))
            {
                msg = "Bei 'Werteliste Bis' bitte eine Zahl eingeben";
                MessageBox.Show(msg);
            }
            else
            {
                Random rnd = new();
                string text = "";
                for (int i = 0; i < anzahl; i++)
                {
                    if (text != "")
                        text += ",";

                    text += rnd.Next(von, bis).ToString();
                }

                tbValuelist.Text = text;
            }
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            tbValuelist.Text = "";
            tbSearchValue.Text = "";
            cbSearchAlgo.Text = "";
            cbSortAlgo.Text = "";
        }

        private void btPerform_Click(object sender, EventArgs e)
        {
            string msg;
            bool sorted = false;
            bool searched = false;

            logger.Info("Start process...");
            logger.Info("Value list: " + tbValuelist.Text);
            logger.Info("Sort algorithms: " + cbSortAlgo.Text);
            logger.Info("Search algorithms: " + cbSearchAlgo.Text);
            logger.Info("Search value: " + tbSearchValue.Text);

            if (cbSearchAlgo.Text == "" && cbSortAlgo.Text == "")
            {
                msg = "Bitte einen Sortier- oder Suchalgorithmus wählen";
                MessageBox.Show(msg);
                logger.Info(msg);
            }
            else
            {
                int result = -1;
                List<int> iList = GetList(tbValuelist.Text);
                if (cbSortAlgo.Text == "Bubble Sort")
                {
                    iList = SortBubble.Sort(iList);
                    tbValuelist.Text = string.Join(",", iList);
                    sorted = true;
                }
                else if (cbSortAlgo.Text == "optimierter Bubble Sort")
                {
                    iList = SortBubbleOpt.Sort(iList);
                    tbValuelist.Text = string.Join(",", iList);
                    sorted = true;
                }
                else if (cbSortAlgo.Text == "Selection Sort")
                {
                    iList = SortSelect.Sort(iList);
                    tbValuelist.Text = string.Join(",", iList);
                    sorted = true;
                }
                else if (cbSortAlgo.Text != "")
                {
                    msg = "Unbekannter Sortieralgorithmus";
                    MessageBox.Show(msg);
                    logger.Info(msg);
                }

                if (cbSearchAlgo.Text == "Linear Search")
                {
                    Int32.TryParse(tbSearchValue.Text, out int iSearch);
                    result = SearchLinear.Search(iList, iSearch);
                    searched = true;
                }
                else if (cbSearchAlgo.Text == "Binary Search")
                {
                    if (!sorted)
                    {
                        msg = "Binary Search benötigt eine sortierte Liste. Bitte einen Sortieralgorithmus wählen";
                        MessageBox.Show(msg);
                        logger.Info(msg);
                    }
                    else
                    {
                        Int32.TryParse(tbSearchValue.Text, out int iSearch);
                        result = SearchBinary.Search(iList, iSearch);
                        searched = true;

                    }
                }
                else if (cbSearchAlgo.Text != "")
                {
                    msg = "Unbekannter Suchalgorithmus";
                    MessageBox.Show(msg);
                    logger.Info(msg);
                    return;
                }

                if (result == -1 && searched)
                {
                    msg = "Der Suchwert konnte nicht gefunden werden";
                    MessageBox.Show(msg);
                    logger.Info(msg);
                }
                else if (searched)
                {
                    msg = "Suchwert gefunden an Stelle: " + result.ToString();
                    MessageBox.Show(msg);
                    logger.Info(msg);
                }
            }
        }

        private static List<int> GetList(string text)
        {
            List<int> iList = new List<int>();
            List<string> sList = text.Split(',').ToList();
            for (int i = 0; i < sList.Count; i++)
            {
                Int32.TryParse(sList[i], out int value);
                iList.Add(value);
            }
            return iList;
        }
    }
}
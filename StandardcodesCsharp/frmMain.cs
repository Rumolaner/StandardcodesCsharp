using SCCsharpSort;
using SCCsharpSearch;

namespace StandardcodesCsharp
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btAutoFill_Click(object sender, EventArgs e)
        {
            int anzahl, von, bis;
            if (!Int32.TryParse(tbWertelisteAnzahl.Text, out anzahl))
            {
                MessageBox.Show(@"Bei 'Werteliste Anzahl' bitte eine Zahl zwischen 1 und 100 eingeben");
            }
            else if (anzahl < 1 || anzahl > 100)
            {
                MessageBox.Show(@"Bei 'Werteliste Anzahl' bitte eine Zahl zwischen 1 und 100 eingeben");
            }
            else if (!Int32.TryParse(tbWertelisteVon.Text, out von))
            {
                MessageBox.Show(@"Bei 'Werteliste Von' bitte eine Zahl eingeben");
            }
            else if (!Int32.TryParse(tbWertelisteBis.Text, out bis))
            {
                MessageBox.Show(@"Bei 'Werteliste Bis' bitte eine Zahl eingeben");
            }
            else
            {
                Random rnd = new Random();
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
            tbValuelist.Text = "";
            cbSearchAlgo.SelectedIndex = 0;
            cbSortAlgo.SelectedIndex = 0;
        }

        private void btPerform_Click(object sender, EventArgs e)
        {
            bool sorted = false;
            if (cbSearchAlgo.Text == "" && cbSortAlgo.Text == "")
            {
                MessageBox.Show("Bitte einen Sortier- oder Suchalgorithmus wählen");
            }
            else
            {
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
                else if (cbSortAlgo.Text != "")
                {
                    MessageBox.Show("Unbekannter Sortieralgorithmus");
                }

                if (cbSearchAlgo.Text == "Linear Search")
                {
                    int iSearch;
                    Int32.TryParse(tbSearchValue.Text, out iSearch);
                    int result = SearchLinear.search(iList, iSearch);

                    if (result == -1)
                    {
                        MessageBox.Show("Der Suchwert konnte nicht gefunden werden");
                    }
                    else
                    {
                        MessageBox.Show("Suchwert gefunden an Stelle: " + result.ToString());
                    }
                }
                else if (cbSearchAlgo.Text == "Binary Search")
                {
                    if (!sorted)
                    {
                        MessageBox.Show("Binary Search benötigt eine sortierte Liste. Bitte einen Sortieralgorithmus wählen");
                    }
                    else
                    {
                        int iSearch;
                        Int32.TryParse(tbSearchValue.Text, out iSearch);
                        int result = SearchLinear.search(iList, iSearch);

                        if (result == -1)
                        {
                            MessageBox.Show("Der Suchwert konnte nicht gefunden werden");
                        }
                        else
                        {
                            MessageBox.Show("Suchwert gefunden an Stelle: " + result.ToString());
                        }
                    }
                }
                else if (cbSearchAlgo.Text != "")
                {
                    MessageBox.Show("Unbekannter Suchalgorithmus");
                }
            }
        }

        private static List<int> GetList(string text)
        {
            List<int> iList = new List<int>();
            List<string> sList = text.Split(',').ToList();
            for (int i = 0; i < sList.Count; i++)
            {
                int value;
                Int32.TryParse(sList[i], out value);
                iList.Add(value);
            }
            return iList;
        }
    }
}
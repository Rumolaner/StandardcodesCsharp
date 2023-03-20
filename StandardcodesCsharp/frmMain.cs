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
            if (!Int32.TryParse(tbWertelisteAnzahl.Text, out int anzahl))
            {
                MessageBox.Show(@"Bei 'Werteliste Anzahl' bitte eine Zahl zwischen 1 und 100 eingeben");
            }
            else if (anzahl < 1 || anzahl > 100)
            {
                MessageBox.Show(@"Bei 'Werteliste Anzahl' bitte eine Zahl zwischen 1 und 100 eingeben");
            }
            else if (!Int32.TryParse(tbWertelisteVon.Text, out int von))
            {
                MessageBox.Show(@"Bei 'Werteliste Von' bitte eine Zahl eingeben");
            }
            else if (!Int32.TryParse(tbWertelisteBis.Text, out int bis))
            {
                MessageBox.Show(@"Bei 'Werteliste Bis' bitte eine Zahl eingeben");
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
            bool sorted = false;
            bool searched = false;

            if (cbSearchAlgo.Text == "" && cbSortAlgo.Text == "")
            {
                MessageBox.Show("Bitte einen Sortier- oder Suchalgorithmus wählen");
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
                else if (cbSortAlgo.Text != "")
                {
                    MessageBox.Show("Unbekannter Sortieralgorithmus");
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
                        MessageBox.Show("Binary Search benötigt eine sortierte Liste. Bitte einen Sortieralgorithmus wählen");
                    }
                    else
                    {
                        Int32.TryParse(tbSearchValue.Text, out int iSearch);
                        result = SearchLinear.Search(iList, iSearch);
                        searched = true;

                    }
                }
                else if (cbSearchAlgo.Text != "")
                {
                    MessageBox.Show("Unbekannter Suchalgorithmus");
                    return;
                }

                if (result == -1 && searched)
                {
                    MessageBox.Show("Der Suchwert konnte nicht gefunden werden");
                }
                else if (searched)
                {
                    MessageBox.Show("Suchwert gefunden an Stelle: " + result.ToString());
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
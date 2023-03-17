namespace StandardcodesCsharp
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btAutoFill_Click(object sender, EventArgs e)
        {
            int anzahl, von, bis;
            if (!Int32.TryParse(tbWertelisteAnzahl.Text, out anzahl))
            {
                MessageBox.Show(@"Bei Werteliste Anzahl bitte eine Zahl zwischen 1 und 100 eingeben");
            }
            else if (anzahl < 1 || anzahl > 100)
            {
                MessageBox.Show(@"Bei Werteliste Anzahl bitte eine Zahl zwischen 1 und 100 eingeben");
            }
            else if (!Int32.TryParse(tbWertelisteVon.Text, out von))
            {
                MessageBox.Show(@"Bei Werteliste Von bitte eine Zahl eingeben");
            }
            else if (!Int32.TryParse(tbWertelisteBis.Text, out bis))
            {
                MessageBox.Show(@"Bei Werteliste Bis bitte eine Zahl eingeben");
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

        private void tbWertelisteAnzahl_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
namespace SuiteConway
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void BtnPoursuivre_Click(object sender, EventArgs e)
        {
            int nombreCaractere = 0;
            char dernierChiffre = '0';
            string textSuite = "";
            string derniereLigne = TxtSuite.Lines[TxtSuite.Lines.Length - 1];
            char ancienChiffre = derniereLigne[0];
            foreach (char chiffre in derniereLigne)
            {
                if (ancienChiffre == chiffre)
                {
                    nombreCaractere += 1;
                }
                else
                {
                    textSuite = textSuite + nombreCaractere.ToString() + ancienChiffre.ToString();
                    ancienChiffre = chiffre;
                    nombreCaractere = 1;
                }
                dernierChiffre = chiffre;
            }
            textSuite = textSuite + nombreCaractere.ToString() + ancienChiffre.ToString();
            TxtSuite.Text = TxtSuite.Text + "\r\n" + textSuite;
            ancienChiffre = dernierChiffre;
        }
    }
}
namespace Calculatrice
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void BtnCalculer_Click(object sender, EventArgs e)
        {
            decimal resultat;
            if (Decimal.TryParse(TxtPremierTerme.Text, out decimal PremierTerme))
            {
                if (Decimal.TryParse(TxtSecondTerme.Text, out decimal SecondTerme))
                {
                   
                    string Operateur = CmbOperateur.Text;
                    switch (Operateur)
                    {
                        case "+":
                            resultat = PremierTerme + SecondTerme;
                            break;
                        case "-":
                            resultat = PremierTerme - SecondTerme;
                            break;
                        case "x":
                            resultat = PremierTerme * SecondTerme;
                            break;
                        case "/":
                            resultat = PremierTerme / SecondTerme;
                            break;
                        case "%":
                            resultat = PremierTerme % SecondTerme;
                            break;
                        default:
                            MessageBox.Show("L'opérateur ne respect pas le format");
                            return;
                    }
                    if (CbArrondir.Checked)
                    {
                       resultat = Math.Round(resultat, 2);
                    }
                    string message = "Le résultat est " + resultat.ToString();
                    MessageBox.Show(message);

                }
                else
                {
                    MessageBox.Show("Le second terme n'est pas un nombre décimal");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Le premier terme n'est pas un nombre décimal");
                return;
            }
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
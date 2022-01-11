namespace NombrePremier
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void BtnRechercher_Click(object sender, EventArgs e)
        {
            string diviseur = "";
            int nombreDiviseur = 0;
            if (int.TryParse(TxtNombre.Text, out int nombre)) 
            {
                if (nombre >= 1)
                {
                    for (int i = 1; i <= nombre; i++)
                    {
                        if (nombre % i == 0)
                        {
                            diviseur = diviseur + i.ToString() + ", ";
                            nombreDiviseur += 1;
                        }
                    }
                    LblNombreDiviseur.Text = diviseur;
                    if (nombreDiviseur > 2)
                    {
                        RdNon.Checked = true;
                    }
                    else
                    {
                        RdOui.Checked = true;
                    }
                }
                else
                {
                    MessageBox.Show("Le nombre donné n'est pas positif");
                    return;
                }

            }
            else
            {
                MessageBox.Show("Le nombre donné n'est pas valide");
                return;
            }
        }
    }
}
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace MiniExo
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void BtnSurvoler_MouseHover(object sender, EventArgs e)
        {
            BtnSurvoler.Text = "Ne cliquez pas";
        }

        private void BtnSurvoler_MouseLeave(object sender, EventArgs e)
        {
            BtnSurvoler.Text = "Survoler ce bouton pour changer son texte";
        }

        private void BtnSurvoler_Click(object sender, EventArgs e)
        {
            BtnSurvoler.Enabled=false;
        }

        private void TxtChiffre_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(TxtChiffre.Text, "^[0-9]*$"))
            {

            }
            else
            { 
                TxtChiffre.Text = Regex.Replace(TxtChiffre.Text, "[A-z]", string.Empty);
            }
        }

        private void BtnProcessus_Click(object sender, EventArgs e)
        {
            Process[] processus = Process.GetProcesses();
            decimal memoireUsage = 0;
            string nomProcessus = "";
            foreach (Process p in processus)
            {
                if (p.PrivateMemorySize64 > memoireUsage)
                {
                    memoireUsage = p.PrivateMemorySize64;
                    nomProcessus = p.ProcessName;
                }
            }
            MessageBox.Show("Le processus " + nomProcessus + " consomme le plus de mémoire avoir " + ((memoireUsage / 1024) / 1024).ToString() + " Mo consommé");

        }

        private void BtnMajuscules_Click(object sender, EventArgs e)
        {
            foreach (Button btn in GrpBoxMiniExo.Controls.OfType<Button>())
            {
                btn.Text = btn.Text.ToUpper();
            }
            BtnMajuscules.Visible = false;
        }
    }
}
using System.Text.RegularExpressions;

namespace InventaireMail
{
    public partial class FrmPrincipal : Form
    {
        List<string> collectionMail = new List<string>();
        public FrmPrincipal()
        {
            InitializeComponent();
        }
        private void TxtMail_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(TxtMail.Text, @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$"))
            {
                BtnAjouterMail.Enabled = true;
            }
            else
            {
                BtnAjouterMail.Enabled = false;
            }

        }
        private void BtnAjouterMail_Click(object sender, EventArgs e)
        {
            if (ChkDoublons.Checked == true)
            {
                bool existe = true;
                collectionMail.ForEach(delegate (string adresse)
                {
                    if (string.Equals(TxtMail.Text, adresse, StringComparison.CurrentCultureIgnoreCase))
                    {
                        MessageBox.Show("L'adresse mail est déjà enregistrée");
                    }
                    else
                    {
                        existe = false;
                        return;
                    }
                });
                if (existe == false)
                {
                    collectionMail.Add(TxtMail.Text);
                    TxtMail.Text = "";
                }

            }
            else
            {
                collectionMail.Add(TxtMail.Text);
                TxtMail.Text = "";
                MessageBox.Show(collectionMail.Count.ToString());
            }
        }

        private void BtnMailCourt_Click(object sender, EventArgs e)
        {
            int longuer = 0;
            string mailCourt = "";
            int compteur = 0;
            collectionMail.ForEach(delegate (string adresse)
            {
                if (adresse.Length < longuer || longuer == 0)
                {
                    longuer = adresse.Length;
                    mailCourt = adresse + "\r\n";
                    compteur = 1;
                }
                else if (adresse.Length == longuer)
                {
                    mailCourt = mailCourt + adresse + "\r\n";
                    compteur++;
                }
            });
            if (compteur == 1)
            {
                MessageBox.Show("L'adresse mail la plus courte contient " + longuer + " caractère : \r\n" + mailCourt);
            }
            else if (compteur > 1)
            {
                MessageBox.Show("Les adresses mail les plus courtes contiennent " + longuer + " caractère : \r\n" + mailCourt);
            }
        }

        private void BtnFR_Click(object sender, EventArgs e)
        {
            int compteur = 0;
            string mailFR = "";
            collectionMail.ForEach(delegate (string adresse)
            {
                if (Regex.IsMatch(adresse, ".fr$"))
                {
                    compteur++;
                    if (compteur <= 3)
                    {
                        mailFR = mailFR + adresse + "\r\n";
                    }
                }
            });
            if (String.IsNullOrEmpty(mailFR))
            {
                MessageBox.Show("Il n'y a pas d'adresse mail correspondante");
            }
            else
            {
                MessageBox.Show("Il y a " + compteur + " boite mail en .fr : \r\n" + mailFR);
            }
        }

        private void BtnCOM_Click(object sender, EventArgs e)
        {
            int compteur = 0;
            string mailCOM = "";
            collectionMail.ForEach(delegate (string adresse)
            {
                if (Regex.IsMatch(adresse, ".com$"))
                {
                    compteur++;
                    if (compteur <= 3)
                    {
                        mailCOM = mailCOM + adresse + "\r\n";
                    }
                }
            });
            if (String.IsNullOrEmpty(mailCOM))
            {
                MessageBox.Show("Il n'y a pas d'adresse mail correspondante");
            }
            else
            {
                MessageBox.Show("Il y a " + compteur + " boite mail en .com: \r\n" + mailCOM);
            }
        }
    }
}
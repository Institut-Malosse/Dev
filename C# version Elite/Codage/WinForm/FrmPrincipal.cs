namespace WinForm
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            TxtPrenom.Text = Environment.UserName;
            TxtAutreDate.Text = DateTime.Today.ToString("dd/MM/yyyy");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnPremierAlgo_Click(object sender, EventArgs e)
        {
            string r�sultat = "(texte vide)"; // On d�clare une variable chaine contenant "(texte vide)"
            string pr�nom = TxtPrenom.Text; // On d�clare une variable chaine contenant "Jean-Michel"
            if (String.IsNullOrEmpty(pr�nom))
            {
                MessageBox.Show("Le pr�nom ne peut pas �tre vide");
                return;
            }
            else
            {
                if (DateTime.TryParse(TxtDateDeNaissance.Text, out DateTime DateDeNaissance))
                {
                    if (DateTime.TryParse(TxtAutreDate.Text, out DateTime AutreDate))
                    {
                       
                        int age;
                        int i = 0;
                        if (DateDeNaissance > AutreDate) // Si la date de naissance est sup�rieure � l'autre date
                        {
                            // Oui : la date de naissance EST sup�rieure � l'autre date !
                            // On concat�ne une r�ponse pour dire que la personne n'�tait pas n�e
                            r�sultat = pr�nom + " n'�tait m�me pas n�(e) le " + AutreDate.ToString() + " !";
                        }
                        else
                        {
                            // Non : la date de naissance N'EST PAS sup�rieure � l'autre date !
                            while (true) // On d�marre une boucle, avec une variable i, de type entier (it�rateur)
                            {
                                i += 1;
                                if (DateDeNaissance.AddYears(i) > AutreDate) // Si la date de naissance + i ann�e(s) est sup�rieure ou �gale � l'autre date
                                {
                                    // Oui : la date de naissance + i ann�e(s) EST sup�rieure ou �gale � l'autre date !
                                    age = i - 1;
                                    
                                    if (AutreDate > DateTime.Today)
                                    { 
                                            r�sultat = pr�nom + " aura " + age.ToString() + " an(s) !"; // On indique l'age calcul� (qui vaut la valeur de age)
                                    }
                                    else if (AutreDate < DateTime.Today)
                                    {
                                        r�sultat = pr�nom + " avait " + age.ToString() + " an(s) !"; // On indique l'age calcul� (qui vaut la valeur de age)
                                    }
                                    else if (AutreDate == DateTime.Today)
                                    {
                                        r�sultat = pr�nom + " a " + age.ToString() + " an(s) !"; // On indique l'age calcul� (qui vaut la valeur de i)
                                    }
                                    if (DateDeNaissance.Month == AutreDate.Month && DateDeNaissance.Day == AutreDate.Day)
                                    {
                                        r�sultat = r�sultat + " Et c'�tait pile le jour de son anniversaire !";
                                    }
                                    break;
                                }
                            }
                        }

                        MessageBox.Show(r�sultat); // On affiche le r�sultat de l'algorithme dans une boite de message
                    }
                    else
                    {
                        MessageBox.Show("La deuxi�me date ne respecte pas le format");
                    }
                }
                else
                {
                    MessageBox.Show("La date de naissance ne respecte pas le format");
                }
                
            }
        }
    }
}
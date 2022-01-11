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
            string résultat = "(texte vide)"; // On déclare une variable chaine contenant "(texte vide)"
            string prénom = TxtPrenom.Text; // On déclare une variable chaine contenant "Jean-Michel"
            if (String.IsNullOrEmpty(prénom))
            {
                MessageBox.Show("Le prénom ne peut pas être vide");
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
                        if (DateDeNaissance > AutreDate) // Si la date de naissance est supérieure à l'autre date
                        {
                            // Oui : la date de naissance EST supérieure à l'autre date !
                            // On concatène une réponse pour dire que la personne n'était pas née
                            résultat = prénom + " n'était même pas né(e) le " + AutreDate.ToString() + " !";
                        }
                        else
                        {
                            // Non : la date de naissance N'EST PAS supérieure à l'autre date !
                            while (true) // On démarre une boucle, avec une variable i, de type entier (itérateur)
                            {
                                i += 1;
                                if (DateDeNaissance.AddYears(i) > AutreDate) // Si la date de naissance + i année(s) est supérieure ou égale à l'autre date
                                {
                                    // Oui : la date de naissance + i année(s) EST supérieure ou égale à l'autre date !
                                    age = i - 1;
                                    
                                    if (AutreDate > DateTime.Today)
                                    { 
                                            résultat = prénom + " aura " + age.ToString() + " an(s) !"; // On indique l'age calculé (qui vaut la valeur de age)
                                    }
                                    else if (AutreDate < DateTime.Today)
                                    {
                                        résultat = prénom + " avait " + age.ToString() + " an(s) !"; // On indique l'age calculé (qui vaut la valeur de age)
                                    }
                                    else if (AutreDate == DateTime.Today)
                                    {
                                        résultat = prénom + " a " + age.ToString() + " an(s) !"; // On indique l'age calculé (qui vaut la valeur de i)
                                    }
                                    if (DateDeNaissance.Month == AutreDate.Month && DateDeNaissance.Day == AutreDate.Day)
                                    {
                                        résultat = résultat + " Et c'était pile le jour de son anniversaire !";
                                    }
                                    break;
                                }
                            }
                        }

                        MessageBox.Show(résultat); // On affiche le résultat de l'algorithme dans une boite de message
                    }
                    else
                    {
                        MessageBox.Show("La deuxième date ne respecte pas le format");
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
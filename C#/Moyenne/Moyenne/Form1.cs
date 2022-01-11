namespace Moyenne
{
    public partial class Form1 : Form
    {
        decimal[] tabnotes = new decimal[0];
        public Form1()
        {
            InitializeComponent();
            
        }

        private void AjouterNote1_Click(object sender, EventArgs e)
        {
            string notetab1 = SaisieNote1.Text;
            if (decimal.TryParse(notetab1, out decimal value) && (value >= 0 ) && (value <= 20))
            {
                Array.Resize(ref tabnotes, tabnotes.Length +1);
                tabnotes[tabnotes.Length - 1] = value;
                LabelNotes1.Text = tabnotes.Length.ToString();

            }

            else
            {
                MessageBox.Show("Le note saisi n'est pas une valeur valide !"); // Affichage d'une erreur de saisie
            }
        }

        private void AjouterNote2_Click(object sender, EventArgs e)
        {

        }

        private void Médiane1_Click(object sender, EventArgs e)
        {
            Array.Sort(tabnotes);

        }

        private void Moyenne1_Click(object sender, EventArgs e)
        {
            decimal totalnote = tabnotes.Length;
            decimal moyenne = 0;
            for (int i = 0; i < tabnotes.Length; i++)
            {
                totalnote = totalnote + tabnotes[i];
                
            }
            moyenne = totalnote / tabnotes.Length;
            MessageBox.Show("La moyenne est de " + moyenne);
        }
    }
}
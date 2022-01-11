namespace MoyenneNote
{
    public partial class FrmPrincipal : Form
    {
        decimal[] tableauNote = new Decimal[0];
        List<decimal> collectionNote = new List<decimal>();
        public FrmPrincipal()
        {
            InitializeComponent();
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        
        private void BtnAjoutTableau_Click(object sender, EventArgs e)
        {
            decimal note = decimal.Parse(TxtNote.Text.Replace(".", ","));
            Array.Resize(ref tableauNote, tableauNote.Length + 1);
            tableauNote[tableauNote.Length - 1] = note;
            LblNombreNoteTab.Text = tableauNote.Length.ToString();
            TxtNote.Text = "";
        }

        private void BtnMoyenneTab_Click(object sender, EventArgs e)
        {
            decimal totalNote = 0;
            decimal moyenne = 0;
            for (int i = 0; i < tableauNote.Length; i++)
            {
                totalNote = totalNote + tableauNote[i];
            }
            moyenne = totalNote / tableauNote.Length;
            MessageBox.Show("La moyenne est : " + moyenne);
        }

        private void BtnMedianeTab_Click(object sender, EventArgs e)
        {
            Array.Sort(tableauNote);
            if (tableauNote.Length % 2 == 0)
            {
                decimal medianeGauche = tableauNote[tableauNote.Length / 2 - 1];
                decimal medianeDroite = tableauNote[tableauNote.Length / 2];
                decimal medianeMilieu = (medianeDroite + medianeGauche) / 2;
                MessageBox.Show("Le nombre de note est pair donc la médiane est " + medianeMilieu);
            }
            else
            {
                decimal mediane = tableauNote[(tableauNote.Length + 1) / 2 - 1];
                MessageBox.Show("Le nombre de note est impair donc la médiane est " + mediane);
            }
        }

        private void BtnClearTab_Click(object sender, EventArgs e)
        {
            Array.Clear(tableauNote, 0, tableauNote.Length);
            Array.Resize(ref tableauNote, 0);
            LblNombreNoteTab.Text = tableauNote.Length.ToString();
        }

        private void BtnAjoutCollection_Click(object sender, EventArgs e)
        {
            decimal note = decimal.Parse(TxtNote.Text.Replace(".", ","));
            collectionNote.Add(note);
            LblNombreNoteColl.Text = collectionNote.Count.ToString();
            TxtNote.Text = "";
        }

        private void BtnMoyenneColl_Click(object sender, EventArgs e)
        {
            decimal moyenne = collectionNote.Average();
            MessageBox.Show("La moyenne est : " + moyenne);
        }

        private void BtnMedianeColl_Click(object sender, EventArgs e)
        {
            collectionNote.Sort();
            if (collectionNote.Count % 2 == 0)
            {
                decimal medianeGauche = collectionNote[collectionNote.Count / 2 - 1];
                decimal medianeDroite = collectionNote[collectionNote.Count / 2];
                decimal medianeMilieu = (medianeDroite + medianeGauche) / 2;
                MessageBox.Show("Le nombre de note est pair donc la médiane est " + medianeMilieu);
            }
            else
            {
                decimal mediane = collectionNote[(collectionNote.Count + 1) / 2 - 1];
                MessageBox.Show("Le nombre de note est impair donc la médiane est " + mediane);
            }
        }

        private void BtnClearColl_Click(object sender, EventArgs e)
        {
            collectionNote.Clear();
            LblNombreNoteColl.Text = collectionNote.Count.ToString();
        }

        private void TxtNote_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(TxtNote.Text))
            {
                BtnAjoutCollection.Enabled = false;
                BtnAjoutTableau.Enabled = false;
            }
            else if (decimal.TryParse(TxtNote.Text.Replace(".",","), out decimal note) && note >= 0 && note <= 20)
            {
                BtnAjoutCollection.Enabled = true;
                BtnAjoutTableau.Enabled = true;
            }
            else
            {
                BtnAjoutCollection.Enabled = false;
                BtnAjoutTableau.Enabled = false;
            }
            
            
        }

        private void LblNombreNoteTab_TextChanged(object sender, EventArgs e)
        {
            if (LblNombreNoteTab.Text == "0")
            {
                BtnMoyenneTab.Enabled = false;
                BtnMedianeTab.Enabled = false;
            }
            else
            {
                BtnMoyenneTab.Enabled = true;
                BtnMedianeTab.Enabled = true;
            }
        }

        private void LblNombreNoteColl_TextChanged(object sender, EventArgs e)
        {
            if (LblNombreNoteColl.Text == "0")
            {
                BtnMoyenneColl.Enabled = false;
                BtnMedianeColl.Enabled = false;
            }
            else
            {
                BtnMoyenneColl.Enabled = true;
                BtnMedianeColl.Enabled = true;
            }
        }
    }
}
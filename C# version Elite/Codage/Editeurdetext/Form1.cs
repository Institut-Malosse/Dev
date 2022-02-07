using System.Text;

namespace Editeurdetext
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnParcourir_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                TxtChemin.Text = openFileDialog.FileName;
            }
        }

        private void BtnCharger_Click(object sender, EventArgs e)
        {
            TxtContenu.Text = File.ReadAllText(TxtChemin.Text, Encoding.ASCII);
        }

        private void BtnEnregistrer_Click(object sender, EventArgs e)
        {
            File.WriteAllText(path, createText, Encoding.UTF8);
        }
    }
}
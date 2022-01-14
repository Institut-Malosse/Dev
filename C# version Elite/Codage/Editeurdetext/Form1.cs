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
            OpenFileDialog fichierdlg = new OpenFileDialog();
            fichierdlg.ShowDialog = true;
            // Show the FolderBrowserDialog.
            DialogResult result = folderDlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                DestBox1.Text = folderDlg.SelectedPath;
                Environment.SpecialFolder root = folderDlg.RootFolder;
            }
        }
    }
}
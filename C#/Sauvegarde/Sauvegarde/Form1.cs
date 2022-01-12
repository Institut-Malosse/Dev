using System;
using System.IO;
using System.IO.Compression;
using System.Collections;

namespace Sauvegarde
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string txtSource = SourceBox1.Text;
            string txtDest = DestBox1.Text;
            DateTime localDate = DateTime.Now;

            if (Directory.Exists(txtDest) && Directory.Exists(txtSource))
            {
                //MessageBox.Show("Sauvegarde du " + localDate.ToString());
                string nomSauvegarde = "Sauvegarde du " + localDate.ToString("dd.MM.yyyy"+" à " + "HH.mm.ss");
                string cheminACreer = txtDest + "\\" + nomSauvegarde;
                
                DirectoryInfo creation = Directory.CreateDirectory(cheminACreer);
                DirectoryInfo diradeplacer = new DirectoryInfo(txtSource);
                DirectoryInfo[] dirs = diradeplacer.GetDirectories();

                string Dest = cheminACreer + "\\";
                
                FileInfo[] files = diradeplacer.GetFiles();
               /* foreach (FileInfo file in files)
                {
                    string tempPath = Path.Combine(Dest, file.Name);
                    file.CopyTo(tempPath, true);
                }*/
                foreach (string dirPath in Directory.GetDirectories(txtSource, "*", SearchOption.AllDirectories))
                {
                    Directory.CreateDirectory(dirPath.Replace(txtSource, cheminACreer));
                }
                foreach (string newPath in Directory.GetFiles(txtSource, "*.*", SearchOption.AllDirectories))
                {
                    File.Copy(newPath, newPath.Replace(txtSource, cheminACreer), true);
                }
                MessageBox.Show("La sauvegarde du " + localDate.ToString()+" s'est terminée avec succès !");
                ZipFile.CreateFromDirectory(cheminACreer, cheminACreer);
                MessageBox.Show("L'archive du " + localDate.ToString() + " s'est terminée avec succès !");
            }

            else if (!Directory.Exists(txtDest) && Directory.Exists(txtSource))
            {
                MessageBox.Show("Veuillez vérifier la destination. Le chemin saisi semble ne pas être correct !");
            }
            else if (Directory.Exists(txtDest) && !Directory.Exists(txtSource))
            {
                MessageBox.Show("Veuillez vérifier la source. Le chemin saisi semble ne pas être correct !");
            }
            else
            {
                MessageBox.Show("Erreur critique. Vérifiez les champs requis !");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            folderDlg.ShowNewFolderButton = true;
            // Show the FolderBrowserDialog.  
            DialogResult result = folderDlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                SourceBox1.Text = folderDlg.SelectedPath;
                Environment.SpecialFolder root = folderDlg.RootFolder;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            folderDlg.ShowNewFolderButton = true;
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
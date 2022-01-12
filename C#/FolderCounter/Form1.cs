// For File.Exists, Directory.Exists
using System;
using System.IO;
using System.Collections;

namespace FolderCounter
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            string chemin = textBox1.Text;
            if (Directory.Exists(chemin))
            { 
                MessageBox.Show("Le chemin spécifié existe et est un répertoire.");
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                label4.Text = chemin;
                textBox1.Text = "";
            }
            else if (File.Exists(chemin))
            {
                MessageBox.Show("Le chemin spécifié est un fichier et non un répertoire.");
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;

            }
            else if ((!Directory.Exists(chemin) || !File.Exists(chemin)))
            {
                MessageBox.Show("Le chemin spécifié n'existe pas, est incorrect ou n'est pas accessible.");
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string chemin = textBox1.Text;
            if (Directory.Exists(chemin))
            {
                int nbFichiers = Directory.GetFiles(chemin, "*", SearchOption.TopDirectoryOnly).Length;
                MessageBox.Show("Le répertoire contient " + nbFichiers + " fichiers à l'intérieur.");
            }
            else
            {
                MessageBox.Show("Le chemin spécifié n'existe pas, est incorrect ou n'est pas accessible. Impossible de compter le néant.");
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string chemin = textBox1.Text;
            if (Directory.Exists(chemin))
            {

                string[] files = Directory.GetFiles(chemin, "*");
                string str = "";
                Array.Sort(files);
                foreach (var file in files)
                {

                    str = str + file.Replace(chemin + "\\", "") + "\r\n";

                }
                MessageBox.Show(str);


            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string chemin = textBox1.Text;
            if (Directory.Exists(chemin))
            {

                string[] files = Directory.GetFiles(chemin, "*");
                string str = "";
                Array.Reverse(files);
                foreach (var file in files)
                {

                    str = str + file.Replace(chemin + "\\", "") + "\r\n";

                }
                MessageBox.Show(str);


            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string chemin = textBox1.Text;
            string extension = "*." + textBox2.Text;
            if (Directory.Exists(chemin))
            {

                string[] files = Directory.GetFiles(chemin, extension);
                string str = "";
                Array.Sort(files);
                foreach (var file in files)
                {

                    str = str + file.Replace(chemin + "\\", "") + "\r\n";

                }
                MessageBox.Show(str);


            }
        }
    }
}
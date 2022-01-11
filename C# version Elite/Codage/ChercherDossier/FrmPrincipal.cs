using System;
using System.IO;
using System.Collections;

namespace ChercherDossier
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void BtnExistance_Click(object sender, EventArgs e)
        {
            string cheminDossier = TxtDossier.Text;
            if (String.IsNullOrEmpty(cheminDossier))
            {
                MessageBox.Show("Le chemin de dossier ne peut pas être vide");
            }
            if(Directory.Exists(cheminDossier))
            {
                MessageBox.Show("Le dossier " + cheminDossier + " existe");
                BtnListeFichierAZ.Enabled = true;
                BtnListeFichiersZA.Enabled = true;
                BtnNombreFichierExt.Enabled = true;
                TxtExtension.Enabled = true;
                BtnNombreFichiers.Enabled = true;
            }
            else if (File.Exists(cheminDossier))
            {
                MessageBox.Show("Le chemin définie correspond à un fichier");
            }
            else
            {
                MessageBox.Show("Le chemin spécifié ne correspond à aucun dossier ni fichier");
            }
        }

        private void BtnNombreFichiers_Click(object sender, EventArgs e)
        {
            String cheminDossier = TxtDossier.Text;
            if (String.IsNullOrEmpty(cheminDossier))
            {
                MessageBox.Show("Le chemin de dossier ne peut pas être vide");
            }
            if (Directory.Exists(cheminDossier))
            {
                int nombreDossier = Directory.GetFiles(cheminDossier, "*", SearchOption.TopDirectoryOnly).Length;
                MessageBox.Show("Il y a " + nombreDossier + " fichier(s) dans ce dossier");
            }
            else
            {
                {
                    MessageBox.Show("Le chemin spécifié ne correspond à aucun dossier");
                }
            }
        }

        private void TxtDossier_TextChanged(object sender, EventArgs e)
        {
            BtnListeFichierAZ.Enabled = false;
            BtnListeFichiersZA.Enabled = false;
            BtnNombreFichierExt.Enabled = false;
            TxtExtension.Enabled = false;
            BtnNombreFichiers.Enabled = false;
        }

        private void BtnListeFichierAZ_Click(object sender, EventArgs e)
        {
            string cheminDossier = TxtDossier.Text;
            string listeFichiers = "";
            string[] fichiers = Directory.GetFiles(cheminDossier, "*", SearchOption.TopDirectoryOnly);
            if (fichiers.Length > 0)
            {
                Array.Sort(fichiers);
                for (int i = 0; i < fichiers.Length; i++)
                {
                    listeFichiers = listeFichiers + fichiers[i] + "\r\n";
                }
                MessageBox.Show(listeFichiers);
            }
            else
            {
                MessageBox.Show("Il n'y a pas de fichier dans ce dossier");
            }

        }

        private void BtnListeFichiersZA_Click(object sender, EventArgs e)
        {
            string cheminDossier = TxtDossier.Text;
            string listeFichiers = "";
            string[] fichiers = Directory.GetFiles(cheminDossier, "*", SearchOption.TopDirectoryOnly);
            if (fichiers.Length > 0)
            {
                Array.Sort(fichiers);
                Array.Reverse(fichiers);
                for (int i = 0; i < fichiers.Length; i++)
                {
                    listeFichiers = listeFichiers + fichiers[i] + "\r\n";
                }
                MessageBox.Show(listeFichiers);
            }
            else
            {
                MessageBox.Show("Il n'y a pas de fichier dans ce dossier");
            }
        }

        private void BtnNombreFichierExt_Click(object sender, EventArgs e)
        {
            string listeFichiers = "";
            string cheminDossier = TxtDossier.Text;
            string extension = TxtExtension.Text;
            if (String.IsNullOrEmpty(extension))
            {
                MessageBox.Show("Veuillez entrer une extension.");
            }
            else
            {
                string[] fichiers = Directory.GetFiles(cheminDossier, "*" + extension, SearchOption.TopDirectoryOnly);
                if (fichiers.Length > 0)
                {
                    for (int i = 0; i < fichiers.Length; i++)
                    {
                        listeFichiers = listeFichiers + fichiers[i] + "\r\n";
                    }
                    MessageBox.Show("Il y a " + fichiers.Length + " fichier(s) avec cette extension. \r\n" + listeFichiers);
                }
                else
                {
                    MessageBox.Show("Aucun fichier ne correspond à votre recherche.");
                }
            }
 
        }
    }
}
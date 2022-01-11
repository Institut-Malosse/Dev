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
            String cheminDossier = TxtDossier.Text;
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
                MessageBox.Show("Il y a " + nombreDossier + "fichier dans ce dossier");
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
        }
    }
}
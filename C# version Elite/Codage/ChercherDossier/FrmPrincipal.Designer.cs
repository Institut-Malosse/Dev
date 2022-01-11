namespace ChercherDossier
{
    partial class FrmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.TxtDossier = new System.Windows.Forms.TextBox();
            this.BtnExistance = new System.Windows.Forms.Button();
            this.BtnNombreFichiers = new System.Windows.Forms.Button();
            this.BtnListeFichierAZ = new System.Windows.Forms.Button();
            this.BtnListeFichiersZA = new System.Windows.Forms.Button();
            this.BtnNombreFichierExt = new System.Windows.Forms.Button();
            this.TxtExtension = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dossier :";
            // 
            // TxtDossier
            // 
            this.TxtDossier.Location = new System.Drawing.Point(67, 61);
            this.TxtDossier.Name = "TxtDossier";
            this.TxtDossier.Size = new System.Drawing.Size(564, 23);
            this.TxtDossier.TabIndex = 1;
            this.TxtDossier.TextChanged += new System.EventHandler(this.TxtDossier_TextChanged);
            // 
            // BtnExistance
            // 
            this.BtnExistance.Location = new System.Drawing.Point(67, 113);
            this.BtnExistance.Name = "BtnExistance";
            this.BtnExistance.Size = new System.Drawing.Size(190, 42);
            this.BtnExistance.TabIndex = 2;
            this.BtnExistance.Text = "Le dossier existe-t-il ?";
            this.BtnExistance.UseVisualStyleBackColor = true;
            this.BtnExistance.Click += new System.EventHandler(this.BtnExistance_Click);
            // 
            // BtnNombreFichiers
            // 
            this.BtnNombreFichiers.Location = new System.Drawing.Point(335, 113);
            this.BtnNombreFichiers.Name = "BtnNombreFichiers";
            this.BtnNombreFichiers.Size = new System.Drawing.Size(191, 41);
            this.BtnNombreFichiers.TabIndex = 3;
            this.BtnNombreFichiers.Text = "Nombre de fichiers dans ce dossier ?";
            this.BtnNombreFichiers.UseVisualStyleBackColor = true;
            this.BtnNombreFichiers.Click += new System.EventHandler(this.BtnNombreFichiers_Click);
            // 
            // BtnListeFichierAZ
            // 
            this.BtnListeFichierAZ.Enabled = false;
            this.BtnListeFichierAZ.Location = new System.Drawing.Point(67, 176);
            this.BtnListeFichierAZ.Name = "BtnListeFichierAZ";
            this.BtnListeFichierAZ.Size = new System.Drawing.Size(190, 39);
            this.BtnListeFichierAZ.TabIndex = 4;
            this.BtnListeFichierAZ.Text = "Liste des fichiers (triés de A à Z)";
            this.BtnListeFichierAZ.UseVisualStyleBackColor = true;
            // 
            // BtnListeFichiersZA
            // 
            this.BtnListeFichiersZA.Enabled = false;
            this.BtnListeFichiersZA.Location = new System.Drawing.Point(335, 176);
            this.BtnListeFichiersZA.Name = "BtnListeFichiersZA";
            this.BtnListeFichiersZA.Size = new System.Drawing.Size(191, 39);
            this.BtnListeFichiersZA.TabIndex = 5;
            this.BtnListeFichiersZA.Text = "Liste des fichiers (triés de Z à A)";
            this.BtnListeFichiersZA.UseVisualStyleBackColor = true;
            // 
            // BtnNombreFichierExt
            // 
            this.BtnNombreFichierExt.Enabled = false;
            this.BtnNombreFichierExt.Location = new System.Drawing.Point(67, 242);
            this.BtnNombreFichierExt.Name = "BtnNombreFichierExt";
            this.BtnNombreFichierExt.Size = new System.Drawing.Size(335, 23);
            this.BtnNombreFichierExt.TabIndex = 6;
            this.BtnNombreFichierExt.Text = "Compter le nombre de fichiers avec cette extension : ";
            this.BtnNombreFichierExt.UseVisualStyleBackColor = true;
            // 
            // TxtExtension
            // 
            this.TxtExtension.Enabled = false;
            this.TxtExtension.Location = new System.Drawing.Point(426, 243);
            this.TxtExtension.Name = "TxtExtension";
            this.TxtExtension.Size = new System.Drawing.Size(100, 23);
            this.TxtExtension.TabIndex = 7;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TxtExtension);
            this.Controls.Add(this.BtnNombreFichierExt);
            this.Controls.Add(this.BtnListeFichiersZA);
            this.Controls.Add(this.BtnListeFichierAZ);
            this.Controls.Add(this.BtnNombreFichiers);
            this.Controls.Add(this.BtnExistance);
            this.Controls.Add(this.TxtDossier);
            this.Controls.Add(this.label1);
            this.Name = "FrmPrincipal";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox TxtDossier;
        private Button BtnExistance;
        private Button BtnNombreFichiers;
        private Button BtnListeFichierAZ;
        private Button BtnListeFichiersZA;
        private Button BtnNombreFichierExt;
        private TextBox TxtExtension;
    }
}
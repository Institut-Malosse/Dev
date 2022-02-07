namespace Editeurdetext
{
    partial class Form1
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
            this.TxtChemin = new System.Windows.Forms.TextBox();
            this.BtnParcourir = new System.Windows.Forms.Button();
            this.BtnCharger = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtContenu = new System.Windows.Forms.TextBox();
            this.BtnEnregistrer = new System.Windows.Forms.Button();
            this.BtnSauvegarder = new System.Windows.Forms.Button();
            this.BtnSupprimer = new System.Windows.Forms.Button();
            this.BtnOuvrir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fichier de travail";
            // 
            // TxtChemin
            // 
            this.TxtChemin.Location = new System.Drawing.Point(36, 63);
            this.TxtChemin.Name = "TxtChemin";
            this.TxtChemin.Size = new System.Drawing.Size(496, 23);
            this.TxtChemin.TabIndex = 1;
            // 
            // BtnParcourir
            // 
            this.BtnParcourir.Location = new System.Drawing.Point(563, 63);
            this.BtnParcourir.Name = "BtnParcourir";
            this.BtnParcourir.Size = new System.Drawing.Size(75, 23);
            this.BtnParcourir.TabIndex = 2;
            this.BtnParcourir.Text = "Parcourir ...";
            this.BtnParcourir.UseVisualStyleBackColor = true;
            this.BtnParcourir.Click += new System.EventHandler(this.BtnParcourir_Click);
            // 
            // BtnCharger
            // 
            this.BtnCharger.Location = new System.Drawing.Point(184, 121);
            this.BtnCharger.Name = "BtnCharger";
            this.BtnCharger.Size = new System.Drawing.Size(323, 23);
            this.BtnCharger.TabIndex = 3;
            this.BtnCharger.Text = "Charger le contenu du fichier";
            this.BtnCharger.UseVisualStyleBackColor = true;
            this.BtnCharger.Click += new System.EventHandler(this.BtnCharger_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Contenu :";
            // 
            // TxtContenu
            // 
            this.TxtContenu.Location = new System.Drawing.Point(39, 189);
            this.TxtContenu.Multiline = true;
            this.TxtContenu.Name = "TxtContenu";
            this.TxtContenu.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtContenu.Size = new System.Drawing.Size(711, 268);
            this.TxtContenu.TabIndex = 5;
            // 
            // BtnEnregistrer
            // 
            this.BtnEnregistrer.Location = new System.Drawing.Point(184, 463);
            this.BtnEnregistrer.Name = "BtnEnregistrer";
            this.BtnEnregistrer.Size = new System.Drawing.Size(348, 23);
            this.BtnEnregistrer.TabIndex = 6;
            this.BtnEnregistrer.Text = "Enregistrer le contenu";
            this.BtnEnregistrer.UseVisualStyleBackColor = true;
            this.BtnEnregistrer.Click += new System.EventHandler(this.BtnEnregistrer_Click);
            // 
            // BtnSauvegarder
            // 
            this.BtnSauvegarder.Location = new System.Drawing.Point(39, 499);
            this.BtnSauvegarder.Name = "BtnSauvegarder";
            this.BtnSauvegarder.Size = new System.Drawing.Size(711, 23);
            this.BtnSauvegarder.TabIndex = 7;
            this.BtnSauvegarder.Text = "Faire une sauvegarde du fichier de  travail dans un sous-dossier";
            this.BtnSauvegarder.UseVisualStyleBackColor = true;
            // 
            // BtnSupprimer
            // 
            this.BtnSupprimer.Location = new System.Drawing.Point(37, 531);
            this.BtnSupprimer.Name = "BtnSupprimer";
            this.BtnSupprimer.Size = new System.Drawing.Size(332, 23);
            this.BtnSupprimer.TabIndex = 8;
            this.BtnSupprimer.Text = "Supprimer le répertoire de sauvegarde";
            this.BtnSupprimer.UseVisualStyleBackColor = true;
            // 
            // BtnOuvrir
            // 
            this.BtnOuvrir.Location = new System.Drawing.Point(375, 531);
            this.BtnOuvrir.Name = "BtnOuvrir";
            this.BtnOuvrir.Size = new System.Drawing.Size(375, 23);
            this.BtnOuvrir.TabIndex = 9;
            this.BtnOuvrir.Text = "Ouvrir le répertoire de sauvegarde";
            this.BtnOuvrir.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 564);
            this.Controls.Add(this.BtnOuvrir);
            this.Controls.Add(this.BtnSupprimer);
            this.Controls.Add(this.BtnSauvegarder);
            this.Controls.Add(this.BtnEnregistrer);
            this.Controls.Add(this.TxtContenu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnCharger);
            this.Controls.Add(this.BtnParcourir);
            this.Controls.Add(this.TxtChemin);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox TxtChemin;
        private Button BtnParcourir;
        private Button BtnCharger;
        private Label label2;
        private TextBox TxtContenu;
        private Button BtnEnregistrer;
        private Button BtnSauvegarder;
        private Button BtnSupprimer;
        private Button BtnOuvrir;
    }
}
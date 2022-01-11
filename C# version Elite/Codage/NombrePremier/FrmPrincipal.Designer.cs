namespace NombrePremier
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
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.BtnRechercher = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.LblNombreDiviseur = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.RdOui = new System.Windows.Forms.RadioButton();
            this.RdNon = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Saisir un nombre entier et positif : ";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(280, 49);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(100, 23);
            this.TxtNombre.TabIndex = 1;
            // 
            // BtnRechercher
            // 
            this.BtnRechercher.Location = new System.Drawing.Point(59, 96);
            this.BtnRechercher.Name = "BtnRechercher";
            this.BtnRechercher.Size = new System.Drawing.Size(205, 36);
            this.BtnRechercher.TabIndex = 2;
            this.BtnRechercher.Text = "Rechercher les diviseurs";
            this.BtnRechercher.UseVisualStyleBackColor = true;
            this.BtnRechercher.Click += new System.EventHandler(this.BtnRechercher_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Diviseurs trouvés :";
            // 
            // LblNombreDiviseur
            // 
            this.LblNombreDiviseur.AutoSize = true;
            this.LblNombreDiviseur.Location = new System.Drawing.Point(166, 165);
            this.LblNombreDiviseur.Name = "LblNombreDiviseur";
            this.LblNombreDiviseur.Size = new System.Drawing.Size(29, 15);
            this.LblNombreDiviseur.TabIndex = 4;
            this.LblNombreDiviseur.Text = "N/A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Le nombre est premier :";
            // 
            // RdOui
            // 
            this.RdOui.AutoSize = true;
            this.RdOui.Enabled = false;
            this.RdOui.Location = new System.Drawing.Point(202, 201);
            this.RdOui.Name = "RdOui";
            this.RdOui.Size = new System.Drawing.Size(44, 19);
            this.RdOui.TabIndex = 6;
            this.RdOui.TabStop = true;
            this.RdOui.Text = "Oui";
            this.RdOui.UseVisualStyleBackColor = true;
            // 
            // RdNon
            // 
            this.RdNon.AutoSize = true;
            this.RdNon.Enabled = false;
            this.RdNon.Location = new System.Drawing.Point(271, 201);
            this.RdNon.Name = "RdNon";
            this.RdNon.Size = new System.Drawing.Size(48, 19);
            this.RdNon.TabIndex = 7;
            this.RdNon.TabStop = true;
            this.RdNon.Text = "Non";
            this.RdNon.UseVisualStyleBackColor = true;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RdNon);
            this.Controls.Add(this.RdOui);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LblNombreDiviseur);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnRechercher);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.label1);
            this.Name = "FrmPrincipal";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox TxtNombre;
        private Button BtnRechercher;
        private Label label2;
        private Label LblNombreDiviseur;
        private Label label3;
        private RadioButton RdOui;
        private RadioButton RdNon;
    }
}
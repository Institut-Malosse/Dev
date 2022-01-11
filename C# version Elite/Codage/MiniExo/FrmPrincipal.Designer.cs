namespace MiniExo
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
            this.GrpBoxMiniExo = new System.Windows.Forms.GroupBox();
            this.BtnMajuscules = new System.Windows.Forms.Button();
            this.TxtChiffre = new System.Windows.Forms.TextBox();
            this.LblChiffres = new System.Windows.Forms.Label();
            this.BtnProcessus = new System.Windows.Forms.Button();
            this.BtnSurvoler = new System.Windows.Forms.Button();
            this.GrpBoxMiniExo.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrpBoxMiniExo
            // 
            this.GrpBoxMiniExo.Controls.Add(this.BtnMajuscules);
            this.GrpBoxMiniExo.Controls.Add(this.TxtChiffre);
            this.GrpBoxMiniExo.Controls.Add(this.LblChiffres);
            this.GrpBoxMiniExo.Controls.Add(this.BtnProcessus);
            this.GrpBoxMiniExo.Controls.Add(this.BtnSurvoler);
            this.GrpBoxMiniExo.ImeMode = System.Windows.Forms.ImeMode.On;
            this.GrpBoxMiniExo.Location = new System.Drawing.Point(19, 7);
            this.GrpBoxMiniExo.Name = "GrpBoxMiniExo";
            this.GrpBoxMiniExo.Size = new System.Drawing.Size(574, 211);
            this.GrpBoxMiniExo.TabIndex = 0;
            this.GrpBoxMiniExo.TabStop = false;
            this.GrpBoxMiniExo.Text = "MiniExo";
            // 
            // BtnMajuscules
            // 
            this.BtnMajuscules.Location = new System.Drawing.Point(30, 140);
            this.BtnMajuscules.Name = "BtnMajuscules";
            this.BtnMajuscules.Size = new System.Drawing.Size(357, 23);
            this.BtnMajuscules.TabIndex = 4;
            this.BtnMajuscules.Text = "Mettre en majuscules tous les boutons de cet encart ";
            this.BtnMajuscules.UseVisualStyleBackColor = true;
            this.BtnMajuscules.Click += new System.EventHandler(this.BtnMajuscules_Click);
            // 
            // TxtChiffre
            // 
            this.TxtChiffre.AllowDrop = true;
            this.TxtChiffre.Location = new System.Drawing.Point(253, 91);
            this.TxtChiffre.Name = "TxtChiffre";
            this.TxtChiffre.Size = new System.Drawing.Size(100, 23);
            this.TxtChiffre.TabIndex = 3;
            this.TxtChiffre.TextChanged += new System.EventHandler(this.TxtChiffre_TextChanged);
            // 
            // LblChiffres
            // 
            this.LblChiffres.AutoSize = true;
            this.LblChiffres.Location = new System.Drawing.Point(30, 94);
            this.LblChiffres.Name = "LblChiffres";
            this.LblChiffres.Size = new System.Drawing.Size(217, 15);
            this.LblChiffres.TabIndex = 2;
            this.LblChiffres.Text = "Seuls des chiffres peuvent être saisis ici :";
            // 
            // BtnProcessus
            // 
            this.BtnProcessus.Location = new System.Drawing.Point(305, 31);
            this.BtnProcessus.Name = "BtnProcessus";
            this.BtnProcessus.Size = new System.Drawing.Size(245, 54);
            this.BtnProcessus.TabIndex = 1;
            this.BtnProcessus.Text = "Trouver le processus en cours d\'éxecution ayant le plus de mémoire";
            this.BtnProcessus.UseVisualStyleBackColor = true;
            this.BtnProcessus.Click += new System.EventHandler(this.BtnProcessus_Click);
            // 
            // BtnSurvoler
            // 
            this.BtnSurvoler.Location = new System.Drawing.Point(30, 31);
            this.BtnSurvoler.Name = "BtnSurvoler";
            this.BtnSurvoler.Size = new System.Drawing.Size(258, 54);
            this.BtnSurvoler.TabIndex = 0;
            this.BtnSurvoler.Text = "Survoler ce button pour changer son texte";
            this.BtnSurvoler.UseVisualStyleBackColor = true;
            this.BtnSurvoler.Click += new System.EventHandler(this.BtnSurvoler_Click);
            this.BtnSurvoler.MouseLeave += new System.EventHandler(this.BtnSurvoler_MouseLeave);
            this.BtnSurvoler.MouseHover += new System.EventHandler(this.BtnSurvoler_MouseHover);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 221);
            this.Controls.Add(this.GrpBoxMiniExo);
            this.Name = "FrmPrincipal";
            this.Text = "MiniExo";
            this.GrpBoxMiniExo.ResumeLayout(false);
            this.GrpBoxMiniExo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox GrpBoxMiniExo;
        private Button BtnMajuscules;
        private TextBox TxtChiffre;
        private Label LblChiffres;
        private Button BtnProcessus;
        private Button BtnSurvoler;
    }
}
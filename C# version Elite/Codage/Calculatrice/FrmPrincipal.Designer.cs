namespace Calculatrice
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
            this.TxtPremierTerme = new System.Windows.Forms.TextBox();
            this.TxtSecondTerme = new System.Windows.Forms.TextBox();
            this.BtnCalculer = new System.Windows.Forms.Button();
            this.LblPremierTerme = new System.Windows.Forms.Label();
            this.LblOperateur = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CbArrondir = new System.Windows.Forms.CheckBox();
            this.CmbOperateur = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // TxtPremierTerme
            // 
            this.TxtPremierTerme.Location = new System.Drawing.Point(39, 77);
            this.TxtPremierTerme.Name = "TxtPremierTerme";
            this.TxtPremierTerme.Size = new System.Drawing.Size(100, 23);
            this.TxtPremierTerme.TabIndex = 0;
            // 
            // TxtSecondTerme
            // 
            this.TxtSecondTerme.Location = new System.Drawing.Point(330, 77);
            this.TxtSecondTerme.Name = "TxtSecondTerme";
            this.TxtSecondTerme.Size = new System.Drawing.Size(100, 23);
            this.TxtSecondTerme.TabIndex = 2;
            // 
            // BtnCalculer
            // 
            this.BtnCalculer.Location = new System.Drawing.Point(78, 208);
            this.BtnCalculer.Name = "BtnCalculer";
            this.BtnCalculer.Size = new System.Drawing.Size(135, 64);
            this.BtnCalculer.TabIndex = 3;
            this.BtnCalculer.Text = "Calculer";
            this.BtnCalculer.UseVisualStyleBackColor = true;
            this.BtnCalculer.Click += new System.EventHandler(this.BtnCalculer_Click);
            // 
            // LblPremierTerme
            // 
            this.LblPremierTerme.AutoSize = true;
            this.LblPremierTerme.Location = new System.Drawing.Point(39, 50);
            this.LblPremierTerme.Name = "LblPremierTerme";
            this.LblPremierTerme.Size = new System.Drawing.Size(89, 15);
            this.LblPremierTerme.TabIndex = 4;
            this.LblPremierTerme.Text = "Premier Terme :";
            // 
            // LblOperateur
            // 
            this.LblOperateur.AutoSize = true;
            this.LblOperateur.Location = new System.Drawing.Point(183, 50);
            this.LblOperateur.Name = "LblOperateur";
            this.LblOperateur.Size = new System.Drawing.Size(66, 15);
            this.LblOperateur.TabIndex = 5;
            this.LblOperateur.Text = "Opérateur :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(330, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Second Terme :";
            // 
            // CbArrondir
            // 
            this.CbArrondir.AutoSize = true;
            this.CbArrondir.Location = new System.Drawing.Point(78, 151);
            this.CbArrondir.Name = "CbArrondir";
            this.CbArrondir.Size = new System.Drawing.Size(124, 19);
            this.CbArrondir.TabIndex = 8;
            this.CbArrondir.Text = "Arrondir le résultat";
            this.CbArrondir.UseVisualStyleBackColor = true;
            // 
            // CmbOperateur
            // 
            this.CmbOperateur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbOperateur.FormattingEnabled = true;
            this.CmbOperateur.Items.AddRange(new object[] {
            "+",
            "-",
            "x",
            "/",
            "%"});
            this.CmbOperateur.Location = new System.Drawing.Point(174, 77);
            this.CmbOperateur.Name = "CmbOperateur";
            this.CmbOperateur.Size = new System.Drawing.Size(121, 23);
            this.CmbOperateur.TabIndex = 9;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 320);
            this.Controls.Add(this.CmbOperateur);
            this.Controls.Add(this.CbArrondir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LblOperateur);
            this.Controls.Add(this.LblPremierTerme);
            this.Controls.Add(this.BtnCalculer);
            this.Controls.Add(this.TxtSecondTerme);
            this.Controls.Add(this.TxtPremierTerme);
            this.Name = "FrmPrincipal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox TxtPremierTerme;
        private TextBox TxtSecondTerme;
        private Button BtnCalculer;
        private Label LblPremierTerme;
        private Label LblOperateur;
        private Label label3;
        private CheckBox CbArrondir;
        private ComboBox CmbOperateur;
    }
}
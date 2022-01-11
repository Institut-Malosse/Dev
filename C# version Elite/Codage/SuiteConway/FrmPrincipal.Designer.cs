namespace SuiteConway
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
            this.TxtSuite = new System.Windows.Forms.TextBox();
            this.BtnPoursuivre = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtSuite
            // 
            this.TxtSuite.AcceptsReturn = true;
            this.TxtSuite.Location = new System.Drawing.Point(50, 32);
            this.TxtSuite.Multiline = true;
            this.TxtSuite.Name = "TxtSuite";
            this.TxtSuite.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TxtSuite.Size = new System.Drawing.Size(674, 308);
            this.TxtSuite.TabIndex = 0;
            this.TxtSuite.Text = "1";
            // 
            // BtnPoursuivre
            // 
            this.BtnPoursuivre.Location = new System.Drawing.Point(46, 372);
            this.BtnPoursuivre.Name = "BtnPoursuivre";
            this.BtnPoursuivre.Size = new System.Drawing.Size(678, 23);
            this.BtnPoursuivre.TabIndex = 1;
            this.BtnPoursuivre.Text = "Poursuivre la suite de Conway";
            this.BtnPoursuivre.UseVisualStyleBackColor = true;
            this.BtnPoursuivre.Click += new System.EventHandler(this.BtnPoursuivre_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnPoursuivre);
            this.Controls.Add(this.TxtSuite);
            this.Name = "FrmPrincipal";
            this.Text = "Suite de Conway";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox TxtSuite;
        private Button BtnPoursuivre;
    }
}
namespace WinForm
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
            this.BtnPremierAlgo = new System.Windows.Forms.Button();
            this.LblPrenom = new System.Windows.Forms.Label();
            this.LblDateDeNaissance = new System.Windows.Forms.Label();
            this.LblAutreDate = new System.Windows.Forms.Label();
            this.TxtPrenom = new System.Windows.Forms.TextBox();
            this.TxtAutreDate = new System.Windows.Forms.TextBox();
            this.TxtDateDeNaissance = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnPremierAlgo
            // 
            this.BtnPremierAlgo.Location = new System.Drawing.Point(79, 321);
            this.BtnPremierAlgo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnPremierAlgo.Name = "BtnPremierAlgo";
            this.BtnPremierAlgo.Size = new System.Drawing.Size(170, 48);
            this.BtnPremierAlgo.TabIndex = 0;
            this.BtnPremierAlgo.Text = "Premier Algo";
            this.BtnPremierAlgo.UseVisualStyleBackColor = true;
            this.BtnPremierAlgo.Click += new System.EventHandler(this.BtnPremierAlgo_Click);
            // 
            // LblPrenom
            // 
            this.LblPrenom.AutoSize = true;
            this.LblPrenom.Location = new System.Drawing.Point(495, 206);
            this.LblPrenom.Name = "LblPrenom";
            this.LblPrenom.Size = new System.Drawing.Size(49, 15);
            this.LblPrenom.TabIndex = 1;
            this.LblPrenom.Text = "Prénom";
            // 
            // LblDateDeNaissance
            // 
            this.LblDateDeNaissance.AutoSize = true;
            this.LblDateDeNaissance.Location = new System.Drawing.Point(495, 238);
            this.LblDateDeNaissance.Name = "LblDateDeNaissance";
            this.LblDateDeNaissance.Size = new System.Drawing.Size(101, 15);
            this.LblDateDeNaissance.TabIndex = 2;
            this.LblDateDeNaissance.Text = "Date de naissance";
            // 
            // LblAutreDate
            // 
            this.LblAutreDate.AutoSize = true;
            this.LblAutreDate.Location = new System.Drawing.Point(495, 269);
            this.LblAutreDate.Name = "LblAutreDate";
            this.LblAutreDate.Size = new System.Drawing.Size(62, 15);
            this.LblAutreDate.TabIndex = 3;
            this.LblAutreDate.Text = "Autre date";
            // 
            // TxtPrenom
            // 
            this.TxtPrenom.Location = new System.Drawing.Point(660, 206);
            this.TxtPrenom.Name = "TxtPrenom";
            this.TxtPrenom.Size = new System.Drawing.Size(100, 23);
            this.TxtPrenom.TabIndex = 4;
            // 
            // TxtAutreDate
            // 
            this.TxtAutreDate.Location = new System.Drawing.Point(660, 269);
            this.TxtAutreDate.Name = "TxtAutreDate";
            this.TxtAutreDate.Size = new System.Drawing.Size(100, 23);
            this.TxtAutreDate.TabIndex = 6;
            // 
            // TxtDateDeNaissance
            // 
            this.TxtDateDeNaissance.Location = new System.Drawing.Point(660, 238);
            this.TxtDateDeNaissance.Name = "TxtDateDeNaissance";
            this.TxtDateDeNaissance.Size = new System.Drawing.Size(100, 23);
            this.TxtDateDeNaissance.TabIndex = 5;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 426);
            this.Controls.Add(this.TxtDateDeNaissance);
            this.Controls.Add(this.TxtAutreDate);
            this.Controls.Add(this.TxtPrenom);
            this.Controls.Add(this.LblAutreDate);
            this.Controls.Add(this.LblDateDeNaissance);
            this.Controls.Add(this.LblPrenom);
            this.Controls.Add(this.BtnPremierAlgo);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmPrincipal";
            this.Text = "FrmPrincipale";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BtnPremierAlgo;
        private Label LblPrenom;
        private Label LblDateDeNaissance;
        private Label LblAutreDate;
        private TextBox TxtPrenom;
        private TextBox TxtAutreDate;
        private TextBox TxtDateDeNaissance;
    }
}
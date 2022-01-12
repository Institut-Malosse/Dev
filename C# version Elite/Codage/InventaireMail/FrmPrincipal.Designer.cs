namespace InventaireMail
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
            this.GrpboxInvMail = new System.Windows.Forms.GroupBox();
            this.BtnGO = new System.Windows.Forms.Button();
            this.TxtDomaine = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnCOM = new System.Windows.Forms.Button();
            this.BtnFR = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnMailCourt = new System.Windows.Forms.Button();
            this.ChkDoublons = new System.Windows.Forms.CheckBox();
            this.BtnAjouterMail = new System.Windows.Forms.Button();
            this.TxtMail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GrpboxInvMail.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrpboxInvMail
            // 
            this.GrpboxInvMail.Controls.Add(this.BtnGO);
            this.GrpboxInvMail.Controls.Add(this.TxtDomaine);
            this.GrpboxInvMail.Controls.Add(this.label3);
            this.GrpboxInvMail.Controls.Add(this.BtnCOM);
            this.GrpboxInvMail.Controls.Add(this.BtnFR);
            this.GrpboxInvMail.Controls.Add(this.label2);
            this.GrpboxInvMail.Controls.Add(this.BtnMailCourt);
            this.GrpboxInvMail.Controls.Add(this.ChkDoublons);
            this.GrpboxInvMail.Controls.Add(this.BtnAjouterMail);
            this.GrpboxInvMail.Controls.Add(this.TxtMail);
            this.GrpboxInvMail.Controls.Add(this.label1);
            this.GrpboxInvMail.Location = new System.Drawing.Point(12, 12);
            this.GrpboxInvMail.Name = "GrpboxInvMail";
            this.GrpboxInvMail.Size = new System.Drawing.Size(776, 426);
            this.GrpboxInvMail.TabIndex = 0;
            this.GrpboxInvMail.TabStop = false;
            this.GrpboxInvMail.Text = "Inventaire de boite mail";
            // 
            // BtnGO
            // 
            this.BtnGO.Location = new System.Drawing.Point(226, 241);
            this.BtnGO.Name = "BtnGO";
            this.BtnGO.Size = new System.Drawing.Size(57, 33);
            this.BtnGO.TabIndex = 10;
            this.BtnGO.Text = "GO !";
            this.BtnGO.UseVisualStyleBackColor = true;
            // 
            // TxtDomaine
            // 
            this.TxtDomaine.Location = new System.Drawing.Point(42, 247);
            this.TxtDomaine.Name = "TxtDomaine";
            this.TxtDomaine.Size = new System.Drawing.Size(151, 23);
            this.TxtDomaine.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(289, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Trouver les adresses mails dont le om de domaineest :";
            // 
            // BtnCOM
            // 
            this.BtnCOM.Location = new System.Drawing.Point(346, 172);
            this.BtnCOM.Name = "BtnCOM";
            this.BtnCOM.Size = new System.Drawing.Size(47, 23);
            this.BtnCOM.TabIndex = 7;
            this.BtnCOM.Text = ".com";
            this.BtnCOM.UseVisualStyleBackColor = true;
            this.BtnCOM.Click += new System.EventHandler(this.BtnCOM_Click);
            // 
            // BtnFR
            // 
            this.BtnFR.Location = new System.Drawing.Point(287, 172);
            this.BtnFR.Name = "BtnFR";
            this.BtnFR.Size = new System.Drawing.Size(53, 23);
            this.BtnFR.TabIndex = 6;
            this.BtnFR.Text = ".fr";
            this.BtnFR.UseVisualStyleBackColor = true;
            this.BtnFR.Click += new System.EventHandler(this.BtnFR_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Compter les adresses mails terminant par :";
            // 
            // BtnMailCourt
            // 
            this.BtnMailCourt.Location = new System.Drawing.Point(37, 121);
            this.BtnMailCourt.Name = "BtnMailCourt";
            this.BtnMailCourt.Size = new System.Drawing.Size(325, 23);
            this.BtnMailCourt.TabIndex = 4;
            this.BtnMailCourt.Text = "Trouver la ou les adresses mails les plus courtes";
            this.BtnMailCourt.UseVisualStyleBackColor = true;
            this.BtnMailCourt.Click += new System.EventHandler(this.BtnMailCourt_Click);
            // 
            // ChkDoublons
            // 
            this.ChkDoublons.AutoSize = true;
            this.ChkDoublons.Location = new System.Drawing.Point(323, 41);
            this.ChkDoublons.Name = "ChkDoublons";
            this.ChkDoublons.Size = new System.Drawing.Size(140, 19);
            this.ChkDoublons.TabIndex = 3;
            this.ChkDoublons.Text = "Interdire les doublons";
            this.ChkDoublons.UseVisualStyleBackColor = true;
            // 
            // BtnAjouterMail
            // 
            this.BtnAjouterMail.Enabled = false;
            this.BtnAjouterMail.Location = new System.Drawing.Point(331, 70);
            this.BtnAjouterMail.Name = "BtnAjouterMail";
            this.BtnAjouterMail.Size = new System.Drawing.Size(75, 23);
            this.BtnAjouterMail.TabIndex = 2;
            this.BtnAjouterMail.Text = "Ajouter";
            this.BtnAjouterMail.UseVisualStyleBackColor = true;
            this.BtnAjouterMail.Click += new System.EventHandler(this.BtnAjouterMail_Click);
            // 
            // TxtMail
            // 
            this.TxtMail.Location = new System.Drawing.Point(37, 71);
            this.TxtMail.Name = "TxtMail";
            this.TxtMail.PlaceholderText = "exemple@exemple.fr";
            this.TxtMail.Size = new System.Drawing.Size(258, 23);
            this.TxtMail.TabIndex = 1;
            this.TxtMail.TextChanged += new System.EventHandler(this.TxtMail_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Saisir une adresse mail : ";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GrpboxInvMail);
            this.Name = "FrmPrincipal";
            this.Text = "Inventaire mail";
            this.GrpboxInvMail.ResumeLayout(false);
            this.GrpboxInvMail.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox GrpboxInvMail;
        private Label label3;
        private Button BtnCOM;
        private Button BtnFR;
        private Label label2;
        private Button BtnMailCourt;
        private CheckBox ChkDoublons;
        private Button BtnAjouterMail;
        private TextBox TxtMail;
        private Label label1;
        private TextBox TxtDomaine;
        private Button BtnGO;
    }
}
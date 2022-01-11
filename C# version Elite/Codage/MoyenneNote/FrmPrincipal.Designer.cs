namespace MoyenneNote
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnClearColl = new System.Windows.Forms.Button();
            this.BtnClearTab = new System.Windows.Forms.Button();
            this.BtnMedianeColl = new System.Windows.Forms.Button();
            this.BtnMedianeTab = new System.Windows.Forms.Button();
            this.BtnMoyenneColl = new System.Windows.Forms.Button();
            this.BtnMoyenneTab = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LblNombreNoteColl = new System.Windows.Forms.Label();
            this.LblNombreNoteTab = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnAjoutCollection = new System.Windows.Forms.Button();
            this.BtnAjoutTableau = new System.Windows.Forms.Button();
            this.TxtNote = new System.Windows.Forms.TextBox();
            this.LblTextnote = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnClearColl);
            this.groupBox1.Controls.Add(this.BtnClearTab);
            this.groupBox1.Controls.Add(this.BtnMedianeColl);
            this.groupBox1.Controls.Add(this.BtnMedianeTab);
            this.groupBox1.Controls.Add(this.BtnMoyenneColl);
            this.groupBox1.Controls.Add(this.BtnMoyenneTab);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.LblNombreNoteColl);
            this.groupBox1.Controls.Add(this.LblNombreNoteTab);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.BtnAjoutCollection);
            this.groupBox1.Controls.Add(this.BtnAjoutTableau);
            this.groupBox1.Controls.Add(this.TxtNote);
            this.groupBox1.Controls.Add(this.LblTextnote);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(496, 426);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Moyenne des notes";
            // 
            // BtnClearColl
            // 
            this.BtnClearColl.Location = new System.Drawing.Point(333, 364);
            this.BtnClearColl.Name = "BtnClearColl";
            this.BtnClearColl.Size = new System.Drawing.Size(75, 23);
            this.BtnClearColl.TabIndex = 15;
            this.BtnClearColl.Text = "Clear";
            this.BtnClearColl.UseVisualStyleBackColor = true;
            this.BtnClearColl.Click += new System.EventHandler(this.BtnClearColl_Click);
            // 
            // BtnClearTab
            // 
            this.BtnClearTab.Location = new System.Drawing.Point(69, 364);
            this.BtnClearTab.Name = "BtnClearTab";
            this.BtnClearTab.Size = new System.Drawing.Size(75, 23);
            this.BtnClearTab.TabIndex = 14;
            this.BtnClearTab.Text = "Clear";
            this.BtnClearTab.UseVisualStyleBackColor = true;
            this.BtnClearTab.Click += new System.EventHandler(this.BtnClearTab_Click);
            // 
            // BtnMedianeColl
            // 
            this.BtnMedianeColl.Enabled = false;
            this.BtnMedianeColl.Location = new System.Drawing.Point(320, 309);
            this.BtnMedianeColl.Name = "BtnMedianeColl";
            this.BtnMedianeColl.Size = new System.Drawing.Size(105, 28);
            this.BtnMedianeColl.TabIndex = 13;
            this.BtnMedianeColl.Text = "La médiane";
            this.BtnMedianeColl.UseVisualStyleBackColor = true;
            this.BtnMedianeColl.Click += new System.EventHandler(this.BtnMedianeColl_Click);
            // 
            // BtnMedianeTab
            // 
            this.BtnMedianeTab.Enabled = false;
            this.BtnMedianeTab.Location = new System.Drawing.Point(56, 309);
            this.BtnMedianeTab.Name = "BtnMedianeTab";
            this.BtnMedianeTab.Size = new System.Drawing.Size(105, 28);
            this.BtnMedianeTab.TabIndex = 12;
            this.BtnMedianeTab.Text = "La médiane";
            this.BtnMedianeTab.UseVisualStyleBackColor = true;
            this.BtnMedianeTab.Click += new System.EventHandler(this.BtnMedianeTab_Click);
            // 
            // BtnMoyenneColl
            // 
            this.BtnMoyenneColl.Enabled = false;
            this.BtnMoyenneColl.Location = new System.Drawing.Point(320, 274);
            this.BtnMoyenneColl.Name = "BtnMoyenneColl";
            this.BtnMoyenneColl.Size = new System.Drawing.Size(105, 29);
            this.BtnMoyenneColl.TabIndex = 11;
            this.BtnMoyenneColl.Text = "La moyenne";
            this.BtnMoyenneColl.UseVisualStyleBackColor = true;
            this.BtnMoyenneColl.Click += new System.EventHandler(this.BtnMoyenneColl_Click);
            // 
            // BtnMoyenneTab
            // 
            this.BtnMoyenneTab.Enabled = false;
            this.BtnMoyenneTab.Location = new System.Drawing.Point(56, 274);
            this.BtnMoyenneTab.Name = "BtnMoyenneTab";
            this.BtnMoyenneTab.Size = new System.Drawing.Size(105, 29);
            this.BtnMoyenneTab.TabIndex = 10;
            this.BtnMoyenneTab.Text = "La moyenne";
            this.BtnMoyenneTab.UseVisualStyleBackColor = true;
            this.BtnMoyenneTab.Click += new System.EventHandler(this.BtnMoyenneTab_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(320, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Obtenir :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Obtenir :";
            // 
            // LblNombreNoteColl
            // 
            this.LblNombreNoteColl.AutoSize = true;
            this.LblNombreNoteColl.Location = new System.Drawing.Point(355, 222);
            this.LblNombreNoteColl.Name = "LblNombreNoteColl";
            this.LblNombreNoteColl.Size = new System.Drawing.Size(13, 15);
            this.LblNombreNoteColl.TabIndex = 7;
            this.LblNombreNoteColl.Text = "0";
            this.LblNombreNoteColl.TextChanged += new System.EventHandler(this.LblNombreNoteColl_TextChanged);
            // 
            // LblNombreNoteTab
            // 
            this.LblNombreNoteTab.AutoSize = true;
            this.LblNombreNoteTab.Location = new System.Drawing.Point(85, 222);
            this.LblNombreNoteTab.Name = "LblNombreNoteTab";
            this.LblNombreNoteTab.Size = new System.Drawing.Size(13, 15);
            this.LblNombreNoteTab.TabIndex = 6;
            this.LblNombreNoteTab.Text = "0";
            this.LblNombreNoteTab.TextChanged += new System.EventHandler(this.LblNombreNoteTab_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(320, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombre de notes :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre de notes :";
            // 
            // BtnAjoutCollection
            // 
            this.BtnAjoutCollection.Enabled = false;
            this.BtnAjoutCollection.Location = new System.Drawing.Point(320, 111);
            this.BtnAjoutCollection.Name = "BtnAjoutCollection";
            this.BtnAjoutCollection.Size = new System.Drawing.Size(133, 53);
            this.BtnAjoutCollection.TabIndex = 3;
            this.BtnAjoutCollection.Text = "Ajouter à la collection";
            this.BtnAjoutCollection.UseVisualStyleBackColor = true;
            this.BtnAjoutCollection.Click += new System.EventHandler(this.BtnAjoutCollection_Click);
            // 
            // BtnAjoutTableau
            // 
            this.BtnAjoutTableau.Enabled = false;
            this.BtnAjoutTableau.Location = new System.Drawing.Point(56, 109);
            this.BtnAjoutTableau.Name = "BtnAjoutTableau";
            this.BtnAjoutTableau.Size = new System.Drawing.Size(133, 56);
            this.BtnAjoutTableau.TabIndex = 2;
            this.BtnAjoutTableau.Text = "Ajouter au tableau";
            this.BtnAjoutTableau.UseVisualStyleBackColor = true;
            this.BtnAjoutTableau.Click += new System.EventHandler(this.BtnAjoutTableau_Click);
            // 
            // TxtNote
            // 
            this.TxtNote.Location = new System.Drawing.Point(184, 48);
            this.TxtNote.Name = "TxtNote";
            this.TxtNote.Size = new System.Drawing.Size(155, 23);
            this.TxtNote.TabIndex = 1;
            this.TxtNote.TextChanged += new System.EventHandler(this.TxtNote_TextChanged);
            // 
            // LblTextnote
            // 
            this.LblTextnote.AutoSize = true;
            this.LblTextnote.Location = new System.Drawing.Point(184, 30);
            this.LblTextnote.Name = "LblTextnote";
            this.LblTextnote.Size = new System.Drawing.Size(124, 15);
            this.LblTextnote.TabIndex = 0;
            this.LblTextnote.Text = "Saisir une note sur 20 :";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmPrincipal";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private GroupBox groupBox1;
        private Button BtnClearColl;
        private Button BtnClearTab;
        private Button BtnMedianeColl;
        private Button BtnMedianeTab;
        private Button BtnMoyenneColl;
        private Button BtnMoyenneTab;
        private Label label4;
        private Label label3;
        private Label LblNombreNoteColl;
        private Label LblNombreNoteTab;
        private Label label2;
        private Label label1;
        private Button BtnAjoutCollection;
        private Button BtnAjoutTableau;
        private TextBox TxtNote;
        private Label LblTextnote;
    }
}
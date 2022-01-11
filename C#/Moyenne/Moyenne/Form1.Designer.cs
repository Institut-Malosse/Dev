namespace Moyenne
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Clear2 = new System.Windows.Forms.Button();
            this.Moyenne2 = new System.Windows.Forms.Button();
            this.Médiane = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.LabelNotes2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AjouterNote2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Clear1 = new System.Windows.Forms.Button();
            this.Moyenne1 = new System.Windows.Forms.Button();
            this.Médiane1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.LabelNotes1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AjouterNote1 = new System.Windows.Forms.Button();
            this.SaisieNote1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.SaisieNote1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(369, 450);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Moyenne des notes";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Clear2);
            this.groupBox3.Controls.Add(this.Moyenne2);
            this.groupBox3.Controls.Add(this.Médiane);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.LabelNotes2);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.AjouterNote2);
            this.groupBox3.Location = new System.Drawing.Point(186, 129);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(183, 315);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Mode collection";
            // 
            // Clear2
            // 
            this.Clear2.Enabled = false;
            this.Clear2.Location = new System.Drawing.Point(6, 195);
            this.Clear2.Name = "Clear2";
            this.Clear2.Size = new System.Drawing.Size(171, 114);
            this.Clear2.TabIndex = 6;
            this.Clear2.Text = "Clear";
            this.Clear2.UseVisualStyleBackColor = true;
            // 
            // Moyenne2
            // 
            this.Moyenne2.Enabled = false;
            this.Moyenne2.Location = new System.Drawing.Point(6, 161);
            this.Moyenne2.Name = "Moyenne2";
            this.Moyenne2.Size = new System.Drawing.Size(171, 28);
            this.Moyenne2.TabIndex = 5;
            this.Moyenne2.Text = "Moyenne";
            this.Moyenne2.UseVisualStyleBackColor = true;
            // 
            // Médiane
            // 
            this.Médiane.Enabled = false;
            this.Médiane.Location = new System.Drawing.Point(6, 126);
            this.Médiane.Name = "Médiane";
            this.Médiane.Size = new System.Drawing.Size(171, 29);
            this.Médiane.TabIndex = 4;
            this.Médiane.Text = "Médiane";
            this.Médiane.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 15);
            this.label7.TabIndex = 3;
            this.label7.Text = "Obtenir :";
            // 
            // LabelNotes2
            // 
            this.LabelNotes2.AutoSize = true;
            this.LabelNotes2.Location = new System.Drawing.Point(108, 68);
            this.LabelNotes2.Name = "LabelNotes2";
            this.LabelNotes2.Size = new System.Drawing.Size(13, 15);
            this.LabelNotes2.TabIndex = 2;
            this.LabelNotes2.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nombre de notes :";
            // 
            // AjouterNote2
            // 
            this.AjouterNote2.Location = new System.Drawing.Point(6, 22);
            this.AjouterNote2.Name = "AjouterNote2";
            this.AjouterNote2.Size = new System.Drawing.Size(171, 31);
            this.AjouterNote2.TabIndex = 0;
            this.AjouterNote2.Text = "Ajouter la note";
            this.AjouterNote2.UseVisualStyleBackColor = true;
            this.AjouterNote2.Click += new System.EventHandler(this.AjouterNote2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Clear1);
            this.groupBox2.Controls.Add(this.Moyenne1);
            this.groupBox2.Controls.Add(this.Médiane1);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.LabelNotes1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.AjouterNote1);
            this.groupBox2.Location = new System.Drawing.Point(0, 129);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(194, 315);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mode tableau";
            // 
            // Clear1
            // 
            this.Clear1.Enabled = false;
            this.Clear1.Location = new System.Drawing.Point(6, 195);
            this.Clear1.Name = "Clear1";
            this.Clear1.Size = new System.Drawing.Size(174, 114);
            this.Clear1.TabIndex = 6;
            this.Clear1.Text = "Clear";
            this.Clear1.UseVisualStyleBackColor = true;
            // 
            // Moyenne1
            // 
            this.Moyenne1.Location = new System.Drawing.Point(6, 161);
            this.Moyenne1.Name = "Moyenne1";
            this.Moyenne1.Size = new System.Drawing.Size(174, 28);
            this.Moyenne1.TabIndex = 5;
            this.Moyenne1.Text = "Moyenne";
            this.Moyenne1.UseVisualStyleBackColor = true;
            this.Moyenne1.Click += new System.EventHandler(this.Moyenne1_Click);
            // 
            // Médiane1
            // 
            this.Médiane1.Enabled = false;
            this.Médiane1.Location = new System.Drawing.Point(6, 126);
            this.Médiane1.Name = "Médiane1";
            this.Médiane1.Size = new System.Drawing.Size(174, 29);
            this.Médiane1.TabIndex = 4;
            this.Médiane1.Text = "Médiane";
            this.Médiane1.UseVisualStyleBackColor = true;
            this.Médiane1.Click += new System.EventHandler(this.Médiane1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 15);
            this.label6.TabIndex = 3;
            this.label6.Text = "Obtenir :";
            // 
            // LabelNotes1
            // 
            this.LabelNotes1.AutoSize = true;
            this.LabelNotes1.Location = new System.Drawing.Point(108, 68);
            this.LabelNotes1.Name = "LabelNotes1";
            this.LabelNotes1.Size = new System.Drawing.Size(13, 15);
            this.LabelNotes1.TabIndex = 2;
            this.LabelNotes1.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre de notes :";
            // 
            // AjouterNote1
            // 
            this.AjouterNote1.Location = new System.Drawing.Point(6, 22);
            this.AjouterNote1.Name = "AjouterNote1";
            this.AjouterNote1.Size = new System.Drawing.Size(174, 31);
            this.AjouterNote1.TabIndex = 0;
            this.AjouterNote1.Text = "Ajouter la note";
            this.AjouterNote1.UseVisualStyleBackColor = true;
            this.AjouterNote1.Click += new System.EventHandler(this.AjouterNote1_Click);
            // 
            // SaisieNote1
            // 
            this.SaisieNote1.Location = new System.Drawing.Point(153, 45);
            this.SaisieNote1.Name = "SaisieNote1";
            this.SaisieNote1.Size = new System.Drawing.Size(50, 23);
            this.SaisieNote1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Saisissez une note sur 20 :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 474);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox3;
        private Button Moyenne2;
        private Button Médiane;
        private Label label7;
        private Label LabelNotes2;
        private Label label3;
        private Button AjouterNote2;
        private GroupBox groupBox2;
        private Button Clear1;
        private Button Moyenne1;
        private Button Médiane1;
        private Label label6;
        private Label LabelNotes1;
        private Label label2;
        private Button AjouterNote1;
        private TextBox SaisieNote1;
        private Label label1;
        private Button Clear2;
    }
}
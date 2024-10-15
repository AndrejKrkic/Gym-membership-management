namespace Klijent.UserControls
{
    partial class UCKreirajTrenera
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ZapamtiButton1 = new System.Windows.Forms.Button();
            this.Adresalabel1 = new System.Windows.Forms.Label();
            this.Prezimelabel1 = new System.Windows.Forms.Label();
            this.Imelabel1 = new System.Windows.Forms.Label();
            this.AdresatextBox3 = new System.Windows.Forms.TextBox();
            this.PrezimetextBox2 = new System.Windows.Forms.TextBox();
            this.ImetextBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ZapamtiButton1
            // 
            this.ZapamtiButton1.Location = new System.Drawing.Point(90, 265);
            this.ZapamtiButton1.Name = "ZapamtiButton1";
            this.ZapamtiButton1.Size = new System.Drawing.Size(172, 27);
            this.ZapamtiButton1.TabIndex = 13;
            this.ZapamtiButton1.Text = "Zapamti Trenera";
            this.ZapamtiButton1.UseVisualStyleBackColor = true;
            // 
            // Adresalabel1
            // 
            this.Adresalabel1.AutoSize = true;
            this.Adresalabel1.Location = new System.Drawing.Point(40, 150);
            this.Adresalabel1.Name = "Adresalabel1";
            this.Adresalabel1.Size = new System.Drawing.Size(51, 16);
            this.Adresalabel1.TabIndex = 12;
            this.Adresalabel1.Text = "Adresa";
            // 
            // Prezimelabel1
            // 
            this.Prezimelabel1.AutoSize = true;
            this.Prezimelabel1.Location = new System.Drawing.Point(40, 105);
            this.Prezimelabel1.Name = "Prezimelabel1";
            this.Prezimelabel1.Size = new System.Drawing.Size(59, 16);
            this.Prezimelabel1.TabIndex = 11;
            this.Prezimelabel1.Text = "Prezime:";
            // 
            // Imelabel1
            // 
            this.Imelabel1.AutoSize = true;
            this.Imelabel1.Location = new System.Drawing.Point(40, 59);
            this.Imelabel1.Name = "Imelabel1";
            this.Imelabel1.Size = new System.Drawing.Size(29, 16);
            this.Imelabel1.TabIndex = 10;
            this.Imelabel1.Text = "Ime";
            // 
            // AdresatextBox3
            // 
            this.AdresatextBox3.Location = new System.Drawing.Point(107, 150);
            this.AdresatextBox3.Name = "AdresatextBox3";
            this.AdresatextBox3.Size = new System.Drawing.Size(155, 22);
            this.AdresatextBox3.TabIndex = 9;
            this.AdresatextBox3.TextChanged += new System.EventHandler(this.AdresatextBox3_TextChanged);
            // 
            // PrezimetextBox2
            // 
            this.PrezimetextBox2.Location = new System.Drawing.Point(107, 105);
            this.PrezimetextBox2.Name = "PrezimetextBox2";
            this.PrezimetextBox2.Size = new System.Drawing.Size(155, 22);
            this.PrezimetextBox2.TabIndex = 8;
            this.PrezimetextBox2.TextChanged += new System.EventHandler(this.PrezimetextBox2_TextChanged);
            // 
            // ImetextBox1
            // 
            this.ImetextBox1.Location = new System.Drawing.Point(107, 59);
            this.ImetextBox1.Name = "ImetextBox1";
            this.ImetextBox1.Size = new System.Drawing.Size(155, 22);
            this.ImetextBox1.TabIndex = 7;
            this.ImetextBox1.TextChanged += new System.EventHandler(this.ImetextBox1_TextChanged);
            // 
            // UCKreirajTrenera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ZapamtiButton1);
            this.Controls.Add(this.Adresalabel1);
            this.Controls.Add(this.Prezimelabel1);
            this.Controls.Add(this.Imelabel1);
            this.Controls.Add(this.AdresatextBox3);
            this.Controls.Add(this.PrezimetextBox2);
            this.Controls.Add(this.ImetextBox1);
            this.Name = "UCKreirajTrenera";
            this.Size = new System.Drawing.Size(357, 394);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Adresalabel1;
        private System.Windows.Forms.Label Prezimelabel1;
        private System.Windows.Forms.Label Imelabel1;
        public System.Windows.Forms.Button ZapamtiButton1;
        public System.Windows.Forms.TextBox AdresatextBox3;
        public System.Windows.Forms.TextBox PrezimetextBox2;
        public System.Windows.Forms.TextBox ImetextBox1;
    }
}

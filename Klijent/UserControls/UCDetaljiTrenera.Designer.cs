namespace Klijent.UserControls
{
    partial class UCDetaljiTrenera
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
            this.IzmeniButton = new System.Windows.Forms.Button();
            this.ObrisiButton = new System.Windows.Forms.Button();
            this.OdustaniButton = new System.Windows.Forms.Button();
            this.AdresaTextBox1 = new System.Windows.Forms.TextBox();
            this.AdresaLabel1 = new System.Windows.Forms.Label();
            this.PrezimetextBox2 = new System.Windows.Forms.TextBox();
            this.ImetextBox1 = new System.Windows.Forms.TextBox();
            this.PrezimeLabel = new System.Windows.Forms.Label();
            this.ImeLabel = new System.Windows.Forms.Label();
            this.IDLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // IzmeniButton
            // 
            this.IzmeniButton.Location = new System.Drawing.Point(357, 524);
            this.IzmeniButton.Name = "IzmeniButton";
            this.IzmeniButton.Size = new System.Drawing.Size(119, 44);
            this.IzmeniButton.TabIndex = 29;
            this.IzmeniButton.Text = "Sacuvaj izmene";
            this.IzmeniButton.UseVisualStyleBackColor = true;
            // 
            // ObrisiButton
            // 
            this.ObrisiButton.Location = new System.Drawing.Point(184, 524);
            this.ObrisiButton.Name = "ObrisiButton";
            this.ObrisiButton.Size = new System.Drawing.Size(121, 44);
            this.ObrisiButton.TabIndex = 28;
            this.ObrisiButton.Text = "Obrisi trenera";
            this.ObrisiButton.UseVisualStyleBackColor = true;
            // 
            // OdustaniButton
            // 
            this.OdustaniButton.Location = new System.Drawing.Point(23, 532);
            this.OdustaniButton.Name = "OdustaniButton";
            this.OdustaniButton.Size = new System.Drawing.Size(102, 28);
            this.OdustaniButton.TabIndex = 27;
            this.OdustaniButton.Text = "Odustani";
            this.OdustaniButton.UseVisualStyleBackColor = true;
            // 
            // AdresaTextBox1
            // 
            this.AdresaTextBox1.Location = new System.Drawing.Point(139, 136);
            this.AdresaTextBox1.Name = "AdresaTextBox1";
            this.AdresaTextBox1.Size = new System.Drawing.Size(318, 22);
            this.AdresaTextBox1.TabIndex = 26;
            this.AdresaTextBox1.TextChanged += new System.EventHandler(this.AdresaTextBox1_TextChanged);
            // 
            // AdresaLabel1
            // 
            this.AdresaLabel1.AutoSize = true;
            this.AdresaLabel1.Location = new System.Drawing.Point(23, 136);
            this.AdresaLabel1.Name = "AdresaLabel1";
            this.AdresaLabel1.Size = new System.Drawing.Size(51, 16);
            this.AdresaLabel1.TabIndex = 25;
            this.AdresaLabel1.Text = "Adresa";
            // 
            // PrezimetextBox2
            // 
            this.PrezimetextBox2.Location = new System.Drawing.Point(139, 88);
            this.PrezimetextBox2.Name = "PrezimetextBox2";
            this.PrezimetextBox2.ReadOnly = true;
            this.PrezimetextBox2.Size = new System.Drawing.Size(166, 22);
            this.PrezimetextBox2.TabIndex = 24;
            // 
            // ImetextBox1
            // 
            this.ImetextBox1.Location = new System.Drawing.Point(139, 49);
            this.ImetextBox1.Name = "ImetextBox1";
            this.ImetextBox1.ReadOnly = true;
            this.ImetextBox1.Size = new System.Drawing.Size(166, 22);
            this.ImetextBox1.TabIndex = 23;
            // 
            // PrezimeLabel
            // 
            this.PrezimeLabel.AutoSize = true;
            this.PrezimeLabel.Location = new System.Drawing.Point(20, 88);
            this.PrezimeLabel.Name = "PrezimeLabel";
            this.PrezimeLabel.Size = new System.Drawing.Size(56, 16);
            this.PrezimeLabel.TabIndex = 22;
            this.PrezimeLabel.Text = "Prezime";
            // 
            // ImeLabel
            // 
            this.ImeLabel.AutoSize = true;
            this.ImeLabel.Location = new System.Drawing.Point(23, 52);
            this.ImeLabel.Name = "ImeLabel";
            this.ImeLabel.Size = new System.Drawing.Size(32, 16);
            this.ImeLabel.TabIndex = 21;
            this.ImeLabel.Text = "Ime:";
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Location = new System.Drawing.Point(20, 17);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(63, 16);
            this.IDLabel.TabIndex = 20;
            this.IDLabel.Text = "TrenerID:";
            // 
            // UCDetaljiTrenera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.IzmeniButton);
            this.Controls.Add(this.ObrisiButton);
            this.Controls.Add(this.OdustaniButton);
            this.Controls.Add(this.AdresaTextBox1);
            this.Controls.Add(this.AdresaLabel1);
            this.Controls.Add(this.PrezimetextBox2);
            this.Controls.Add(this.ImetextBox1);
            this.Controls.Add(this.PrezimeLabel);
            this.Controls.Add(this.ImeLabel);
            this.Controls.Add(this.IDLabel);
            this.Name = "UCDetaljiTrenera";
            this.Size = new System.Drawing.Size(506, 589);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button IzmeniButton;
        public System.Windows.Forms.Button ObrisiButton;
        public System.Windows.Forms.Button OdustaniButton;
        public System.Windows.Forms.TextBox AdresaTextBox1;
        private System.Windows.Forms.Label AdresaLabel1;
        public System.Windows.Forms.TextBox PrezimetextBox2;
        public System.Windows.Forms.TextBox ImetextBox1;
        private System.Windows.Forms.Label PrezimeLabel;
        private System.Windows.Forms.Label ImeLabel;
        public System.Windows.Forms.Label IDLabel;
    }
}

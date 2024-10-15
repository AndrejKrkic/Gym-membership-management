namespace Klijent.UserControls
{
    partial class UCDetaljiClana
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
            this.MestocomboBox1 = new System.Windows.Forms.ComboBox();
            this.IskustvotextBox3 = new System.Windows.Forms.TextBox();
            this.PrezimetextBox2 = new System.Windows.Forms.TextBox();
            this.ImetextBox1 = new System.Windows.Forms.TextBox();
            this.IzmeniButton = new System.Windows.Forms.Button();
            this.ObrisiButton = new System.Windows.Forms.Button();
            this.OdustaniButton = new System.Windows.Forms.Button();
            this.MestoLabel = new System.Windows.Forms.Label();
            this.IskustvoLabel = new System.Windows.Forms.Label();
            this.PrezimeLabel = new System.Windows.Forms.Label();
            this.ImeLabel = new System.Windows.Forms.Label();
            this.IDLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MestocomboBox1
            // 
            this.MestocomboBox1.FormattingEnabled = true;
            this.MestocomboBox1.Location = new System.Drawing.Point(138, 167);
            this.MestocomboBox1.Name = "MestocomboBox1";
            this.MestocomboBox1.Size = new System.Drawing.Size(166, 24);
            this.MestocomboBox1.TabIndex = 23;
            this.MestocomboBox1.SelectedIndexChanged += new System.EventHandler(this.MestocomboBox1_SelectedIndexChanged);
            // 
            // IskustvotextBox3
            // 
            this.IskustvotextBox3.Location = new System.Drawing.Point(138, 123);
            this.IskustvotextBox3.Name = "IskustvotextBox3";
            this.IskustvotextBox3.Size = new System.Drawing.Size(166, 22);
            this.IskustvotextBox3.TabIndex = 22;
            this.IskustvotextBox3.TextChanged += new System.EventHandler(this.IskustvotextBox3_TextChanged);
            // 
            // PrezimetextBox2
            // 
            this.PrezimetextBox2.Location = new System.Drawing.Point(138, 84);
            this.PrezimetextBox2.Name = "PrezimetextBox2";
            this.PrezimetextBox2.ReadOnly = true;
            this.PrezimetextBox2.Size = new System.Drawing.Size(166, 22);
            this.PrezimetextBox2.TabIndex = 21;
            // 
            // ImetextBox1
            // 
            this.ImetextBox1.Location = new System.Drawing.Point(138, 45);
            this.ImetextBox1.Name = "ImetextBox1";
            this.ImetextBox1.ReadOnly = true;
            this.ImetextBox1.Size = new System.Drawing.Size(166, 22);
            this.ImetextBox1.TabIndex = 20;
            // 
            // IzmeniButton
            // 
            this.IzmeniButton.Location = new System.Drawing.Point(300, 447);
            this.IzmeniButton.Name = "IzmeniButton";
            this.IzmeniButton.Size = new System.Drawing.Size(119, 44);
            this.IzmeniButton.TabIndex = 19;
            this.IzmeniButton.Text = "Sacuvaj izmene";
            this.IzmeniButton.UseVisualStyleBackColor = true;
            // 
            // ObrisiButton
            // 
            this.ObrisiButton.Location = new System.Drawing.Point(158, 447);
            this.ObrisiButton.Name = "ObrisiButton";
            this.ObrisiButton.Size = new System.Drawing.Size(121, 44);
            this.ObrisiButton.TabIndex = 18;
            this.ObrisiButton.Text = "Obrisi clana";
            this.ObrisiButton.UseVisualStyleBackColor = true;
            // 
            // OdustaniButton
            // 
            this.OdustaniButton.Location = new System.Drawing.Point(20, 455);
            this.OdustaniButton.Name = "OdustaniButton";
            this.OdustaniButton.Size = new System.Drawing.Size(102, 28);
            this.OdustaniButton.TabIndex = 17;
            this.OdustaniButton.Text = "Odustani";
            this.OdustaniButton.UseVisualStyleBackColor = true;
            // 
            // MestoLabel
            // 
            this.MestoLabel.AutoSize = true;
            this.MestoLabel.Location = new System.Drawing.Point(19, 167);
            this.MestoLabel.Name = "MestoLabel";
            this.MestoLabel.Size = new System.Drawing.Size(44, 16);
            this.MestoLabel.TabIndex = 16;
            this.MestoLabel.Text = "Mesto";
            // 
            // IskustvoLabel
            // 
            this.IskustvoLabel.AutoSize = true;
            this.IskustvoLabel.Location = new System.Drawing.Point(19, 123);
            this.IskustvoLabel.Name = "IskustvoLabel";
            this.IskustvoLabel.Size = new System.Drawing.Size(103, 16);
            this.IskustvoLabel.TabIndex = 15;
            this.IskustvoLabel.Text = "Meseci iskustva";
            // 
            // PrezimeLabel
            // 
            this.PrezimeLabel.AutoSize = true;
            this.PrezimeLabel.Location = new System.Drawing.Point(19, 84);
            this.PrezimeLabel.Name = "PrezimeLabel";
            this.PrezimeLabel.Size = new System.Drawing.Size(56, 16);
            this.PrezimeLabel.TabIndex = 14;
            this.PrezimeLabel.Text = "Prezime";
            // 
            // ImeLabel
            // 
            this.ImeLabel.AutoSize = true;
            this.ImeLabel.Location = new System.Drawing.Point(22, 48);
            this.ImeLabel.Name = "ImeLabel";
            this.ImeLabel.Size = new System.Drawing.Size(32, 16);
            this.ImeLabel.TabIndex = 13;
            this.ImeLabel.Text = "Ime:";
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Location = new System.Drawing.Point(19, 13);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(50, 16);
            this.IDLabel.TabIndex = 12;
            this.IDLabel.Text = "ClanID:";
            // 
            // UCDetaljiClana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MestocomboBox1);
            this.Controls.Add(this.IskustvotextBox3);
            this.Controls.Add(this.PrezimetextBox2);
            this.Controls.Add(this.ImetextBox1);
            this.Controls.Add(this.IzmeniButton);
            this.Controls.Add(this.ObrisiButton);
            this.Controls.Add(this.OdustaniButton);
            this.Controls.Add(this.MestoLabel);
            this.Controls.Add(this.IskustvoLabel);
            this.Controls.Add(this.PrezimeLabel);
            this.Controls.Add(this.ImeLabel);
            this.Controls.Add(this.IDLabel);
            this.Name = "UCDetaljiClana";
            this.Size = new System.Drawing.Size(451, 528);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox MestocomboBox1;
        public System.Windows.Forms.TextBox IskustvotextBox3;
        public System.Windows.Forms.TextBox PrezimetextBox2;
        public System.Windows.Forms.TextBox ImetextBox1;
        public System.Windows.Forms.Button IzmeniButton;
        public System.Windows.Forms.Button ObrisiButton;
        public System.Windows.Forms.Button OdustaniButton;
        private System.Windows.Forms.Label MestoLabel;
        private System.Windows.Forms.Label IskustvoLabel;
        private System.Windows.Forms.Label PrezimeLabel;
        private System.Windows.Forms.Label ImeLabel;
        public System.Windows.Forms.Label IDLabel;
    }
}

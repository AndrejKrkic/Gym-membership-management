namespace Klijent.UserControls
{
    partial class UCKreirajClana
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
            this.KreirajButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MestoComboBox = new System.Windows.Forms.ComboBox();
            this.MeseciIksustvaTextBox = new System.Windows.Forms.TextBox();
            this.PrezimeTextBox = new System.Windows.Forms.TextBox();
            this.ImeTextBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // KreirajButton
            // 
            this.KreirajButton.BackColor = System.Drawing.Color.Tan;
            this.KreirajButton.Location = new System.Drawing.Point(197, 285);
            this.KreirajButton.Name = "KreirajButton";
            this.KreirajButton.Size = new System.Drawing.Size(100, 34);
            this.KreirajButton.TabIndex = 17;
            this.KreirajButton.Text = "Kreiraj";
            this.KreirajButton.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "Mesto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "MeseciIskustva";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Prezime";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Ime";
            // 
            // MestoComboBox
            // 
            this.MestoComboBox.FormattingEnabled = true;
            this.MestoComboBox.Location = new System.Drawing.Point(160, 186);
            this.MestoComboBox.Name = "MestoComboBox";
            this.MestoComboBox.Size = new System.Drawing.Size(137, 24);
            this.MestoComboBox.TabIndex = 12;
            this.MestoComboBox.SelectedIndexChanged += new System.EventHandler(this.MestoComboBox_SelectedIndexChanged_1);
            // 
            // MeseciIksustvaTextBox
            // 
            this.MeseciIksustvaTextBox.Location = new System.Drawing.Point(160, 143);
            this.MeseciIksustvaTextBox.Name = "MeseciIksustvaTextBox";
            this.MeseciIksustvaTextBox.Size = new System.Drawing.Size(81, 22);
            this.MeseciIksustvaTextBox.TabIndex = 11;
            this.MeseciIksustvaTextBox.TextChanged += new System.EventHandler(this.MeseciIksustvaTextBox_TextChanged_1);
            // 
            // PrezimeTextBox
            // 
            this.PrezimeTextBox.Location = new System.Drawing.Point(160, 100);
            this.PrezimeTextBox.Name = "PrezimeTextBox";
            this.PrezimeTextBox.Size = new System.Drawing.Size(137, 22);
            this.PrezimeTextBox.TabIndex = 10;
            this.PrezimeTextBox.TextChanged += new System.EventHandler(this.PrezimeTextBox_TextChanged_1);
            // 
            // ImeTextBox1
            // 
            this.ImeTextBox1.Location = new System.Drawing.Point(160, 63);
            this.ImeTextBox1.Name = "ImeTextBox1";
            this.ImeTextBox1.Size = new System.Drawing.Size(137, 22);
            this.ImeTextBox1.TabIndex = 9;
            this.ImeTextBox1.TextChanged += new System.EventHandler(this.ImeTextBox1_TextChanged_1);
            // 
            // UCKreirajClana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.KreirajButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MestoComboBox);
            this.Controls.Add(this.MeseciIksustvaTextBox);
            this.Controls.Add(this.PrezimeTextBox);
            this.Controls.Add(this.ImeTextBox1);
            this.Name = "UCKreirajClana";
            this.Size = new System.Drawing.Size(369, 371);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button KreirajButton;
        public System.Windows.Forms.ComboBox MestoComboBox;
        public System.Windows.Forms.TextBox MeseciIksustvaTextBox;
        public System.Windows.Forms.TextBox PrezimeTextBox;
        public System.Windows.Forms.TextBox ImeTextBox1;
    }
}

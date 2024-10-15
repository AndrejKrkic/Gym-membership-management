namespace Klijent.UserControls
{
    partial class UCPretraziClana
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
            this.PretraziButton = new System.Windows.Forms.Button();
            this.DetaljiButton = new System.Windows.Forms.Button();
            this.PretragaTextBox = new System.Windows.Forms.TextBox();
            this.PretragaLabel1 = new System.Windows.Forms.Label();
            this.ClanoviDGV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ClanoviDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // PretraziButton
            // 
            this.PretraziButton.Location = new System.Drawing.Point(627, 27);
            this.PretraziButton.Name = "PretraziButton";
            this.PretraziButton.Size = new System.Drawing.Size(109, 42);
            this.PretraziButton.TabIndex = 9;
            this.PretraziButton.Text = "Pretrazi";
            this.PretraziButton.UseVisualStyleBackColor = true;
            // 
            // DetaljiButton
            // 
            this.DetaljiButton.Location = new System.Drawing.Point(263, 527);
            this.DetaljiButton.Name = "DetaljiButton";
            this.DetaljiButton.Size = new System.Drawing.Size(212, 37);
            this.DetaljiButton.TabIndex = 8;
            this.DetaljiButton.Text = "Detalji clana";
            this.DetaljiButton.UseVisualStyleBackColor = true;
            // 
            // PretragaTextBox
            // 
            this.PretragaTextBox.Location = new System.Drawing.Point(122, 37);
            this.PretragaTextBox.Name = "PretragaTextBox";
            this.PretragaTextBox.Size = new System.Drawing.Size(483, 22);
            this.PretragaTextBox.TabIndex = 7;
            // 
            // PretragaLabel1
            // 
            this.PretragaLabel1.AutoSize = true;
            this.PretragaLabel1.Location = new System.Drawing.Point(21, 40);
            this.PretragaLabel1.Name = "PretragaLabel1";
            this.PretragaLabel1.Size = new System.Drawing.Size(95, 16);
            this.PretragaLabel1.TabIndex = 6;
            this.PretragaLabel1.Text = "Pretraga (Ime):";
            // 
            // ClanoviDGV
            // 
            this.ClanoviDGV.AllowUserToAddRows = false;
            this.ClanoviDGV.AllowUserToDeleteRows = false;
            this.ClanoviDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClanoviDGV.Location = new System.Drawing.Point(24, 96);
            this.ClanoviDGV.Name = "ClanoviDGV";
            this.ClanoviDGV.ReadOnly = true;
            this.ClanoviDGV.RowHeadersWidth = 51;
            this.ClanoviDGV.RowTemplate.Height = 24;
            this.ClanoviDGV.Size = new System.Drawing.Size(712, 407);
            this.ClanoviDGV.TabIndex = 5;
            // 
            // UCPretraziClana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PretraziButton);
            this.Controls.Add(this.DetaljiButton);
            this.Controls.Add(this.PretragaTextBox);
            this.Controls.Add(this.PretragaLabel1);
            this.Controls.Add(this.ClanoviDGV);
            this.Name = "UCPretraziClana";
            this.Size = new System.Drawing.Size(748, 600);
            ((System.ComponentModel.ISupportInitialize)(this.ClanoviDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label PretragaLabel1;
        public System.Windows.Forms.Button PretraziButton;
        public System.Windows.Forms.Button DetaljiButton;
        public System.Windows.Forms.TextBox PretragaTextBox;
        public System.Windows.Forms.DataGridView ClanoviDGV;
    }
}

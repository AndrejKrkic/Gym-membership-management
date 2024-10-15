namespace Klijent.UserControls
{
    partial class UCPretraziTrenera
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
            this.DetaljiButton2 = new System.Windows.Forms.Button();
            this.PretraziTrenralabel1 = new System.Windows.Forms.Label();
            this.PretraziTextBox1 = new System.Windows.Forms.TextBox();
            this.PretraziButton1 = new System.Windows.Forms.Button();
            this.TreneriDGV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.TreneriDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // DetaljiButton2
            // 
            this.DetaljiButton2.Location = new System.Drawing.Point(342, 501);
            this.DetaljiButton2.Name = "DetaljiButton2";
            this.DetaljiButton2.Size = new System.Drawing.Size(142, 39);
            this.DetaljiButton2.TabIndex = 9;
            this.DetaljiButton2.Text = "Detalji trenera";
            this.DetaljiButton2.UseVisualStyleBackColor = true;
            // 
            // PretraziTrenralabel1
            // 
            this.PretraziTrenralabel1.AutoSize = true;
            this.PretraziTrenralabel1.Location = new System.Drawing.Point(23, 26);
            this.PretraziTrenralabel1.Name = "PretraziTrenralabel1";
            this.PretraziTrenralabel1.Size = new System.Drawing.Size(139, 16);
            this.PretraziTrenralabel1.TabIndex = 8;
            this.PretraziTrenralabel1.Text = "Pretrazi Trenera (Ime):";
            // 
            // PretraziTextBox1
            // 
            this.PretraziTextBox1.Location = new System.Drawing.Point(186, 23);
            this.PretraziTextBox1.Name = "PretraziTextBox1";
            this.PretraziTextBox1.Size = new System.Drawing.Size(446, 22);
            this.PretraziTextBox1.TabIndex = 7;
            // 
            // PretraziButton1
            // 
            this.PretraziButton1.Location = new System.Drawing.Point(658, 18);
            this.PretraziButton1.Name = "PretraziButton1";
            this.PretraziButton1.Size = new System.Drawing.Size(120, 32);
            this.PretraziButton1.TabIndex = 6;
            this.PretraziButton1.Text = "Pretrazi";
            this.PretraziButton1.UseVisualStyleBackColor = true;
            // 
            // TreneriDGV
            // 
            this.TreneriDGV.AllowUserToAddRows = false;
            this.TreneriDGV.AllowUserToDeleteRows = false;
            this.TreneriDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TreneriDGV.Location = new System.Drawing.Point(26, 90);
            this.TreneriDGV.Name = "TreneriDGV";
            this.TreneriDGV.ReadOnly = true;
            this.TreneriDGV.RowHeadersWidth = 51;
            this.TreneriDGV.RowTemplate.Height = 24;
            this.TreneriDGV.Size = new System.Drawing.Size(780, 370);
            this.TreneriDGV.TabIndex = 5;
            // 
            // UCPretraziTrenera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DetaljiButton2);
            this.Controls.Add(this.PretraziTrenralabel1);
            this.Controls.Add(this.PretraziTextBox1);
            this.Controls.Add(this.PretraziButton1);
            this.Controls.Add(this.TreneriDGV);
            this.Name = "UCPretraziTrenera";
            this.Size = new System.Drawing.Size(861, 566);
            ((System.ComponentModel.ISupportInitialize)(this.TreneriDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label PretraziTrenralabel1;
        public System.Windows.Forms.Button DetaljiButton2;
        public System.Windows.Forms.TextBox PretraziTextBox1;
        public System.Windows.Forms.Button PretraziButton1;
        public System.Windows.Forms.DataGridView TreneriDGV;
    }
}

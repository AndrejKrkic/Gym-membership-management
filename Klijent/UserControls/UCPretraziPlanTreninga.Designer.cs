namespace Klijent.UserControls
{
    partial class UCPretraziPlanTreninga
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
            this.IzmeniButton2 = new System.Windows.Forms.Button();
            this.PretraziButton1 = new System.Windows.Forms.Button();
            this.PretragaTextBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PlanoviDGV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.PlanoviDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // IzmeniButton2
            // 
            this.IzmeniButton2.Location = new System.Drawing.Point(337, 379);
            this.IzmeniButton2.Name = "IzmeniButton2";
            this.IzmeniButton2.Size = new System.Drawing.Size(120, 37);
            this.IzmeniButton2.TabIndex = 9;
            this.IzmeniButton2.Text = "Izmeni Plan";
            this.IzmeniButton2.UseVisualStyleBackColor = true;
            // 
            // PretraziButton1
            // 
            this.PretraziButton1.Location = new System.Drawing.Point(559, 27);
            this.PretraziButton1.Name = "PretraziButton1";
            this.PretraziButton1.Size = new System.Drawing.Size(100, 23);
            this.PretraziButton1.TabIndex = 8;
            this.PretraziButton1.Text = "Pretrazi";
            this.PretraziButton1.UseVisualStyleBackColor = true;
            // 
            // PretragaTextBox1
            // 
            this.PretragaTextBox1.Location = new System.Drawing.Point(156, 28);
            this.PretragaTextBox1.Name = "PretragaTextBox1";
            this.PretragaTextBox1.Size = new System.Drawing.Size(347, 22);
            this.PretragaTextBox1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Pretrazi plan (naziv)";
            // 
            // PlanoviDGV
            // 
            this.PlanoviDGV.AllowUserToAddRows = false;
            this.PlanoviDGV.AllowUserToDeleteRows = false;
            this.PlanoviDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PlanoviDGV.Location = new System.Drawing.Point(21, 83);
            this.PlanoviDGV.Name = "PlanoviDGV";
            this.PlanoviDGV.ReadOnly = true;
            this.PlanoviDGV.RowHeadersWidth = 51;
            this.PlanoviDGV.RowTemplate.Height = 24;
            this.PlanoviDGV.Size = new System.Drawing.Size(770, 262);
            this.PlanoviDGV.TabIndex = 5;
            // 
            // UCPretraziPlanTreninga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.IzmeniButton2);
            this.Controls.Add(this.PretraziButton1);
            this.Controls.Add(this.PretragaTextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PlanoviDGV);
            this.Name = "UCPretraziPlanTreninga";
            this.Size = new System.Drawing.Size(833, 440);
            ((System.ComponentModel.ISupportInitialize)(this.PlanoviDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button IzmeniButton2;
        public System.Windows.Forms.Button PretraziButton1;
        public System.Windows.Forms.TextBox PretragaTextBox1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView PlanoviDGV;
    }
}

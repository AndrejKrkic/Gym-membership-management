namespace Seminarski_Andrej_Krkic_2020_0206
{
    partial class GlavnaEkranskaForma
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.StartButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.StatusServeraTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.BackColor = System.Drawing.Color.PeachPuff;
            this.StartButton.Location = new System.Drawing.Point(59, 118);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(151, 61);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = false;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.BackColor = System.Drawing.Color.PeachPuff;
            this.StopButton.Location = new System.Drawing.Point(341, 118);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(152, 61);
            this.StopButton.TabIndex = 1;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = false;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // StatusServeraTextBox
            // 
            this.StatusServeraTextBox.Location = new System.Drawing.Point(150, 258);
            this.StatusServeraTextBox.Name = "StatusServeraTextBox";
            this.StatusServeraTextBox.ReadOnly = true;
            this.StatusServeraTextBox.Size = new System.Drawing.Size(300, 22);
            this.StatusServeraTextBox.TabIndex = 2;
            this.StatusServeraTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // GlavnaEkranskaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(582, 450);
            this.Controls.Add(this.StatusServeraTextBox);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.StartButton);
            this.Name = "GlavnaEkranskaForma";
            this.Text = "GlavnaEkranskaForma";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.TextBox StatusServeraTextBox;
    }
}
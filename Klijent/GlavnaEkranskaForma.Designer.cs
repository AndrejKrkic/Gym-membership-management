namespace Klijent
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
            this.kreirajClanaButton = new System.Windows.Forms.Button();
            this.PretraziClanaButton = new System.Windows.Forms.Button();
            this.PorukaUlogovanoglabel = new System.Windows.Forms.Label();
            this.KreirajTreneraButton = new System.Windows.Forms.Button();
            this.PretraziTreneraButton = new System.Windows.Forms.Button();
            this.PlanKreirajButton1 = new System.Windows.Forms.Button();
            this.IzmeniPlanButton1 = new System.Windows.Forms.Button();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // kreirajClanaButton
            // 
            this.kreirajClanaButton.Location = new System.Drawing.Point(37, 51);
            this.kreirajClanaButton.Name = "kreirajClanaButton";
            this.kreirajClanaButton.Size = new System.Drawing.Size(178, 23);
            this.kreirajClanaButton.TabIndex = 0;
            this.kreirajClanaButton.Text = "Kreiraj Clana";
            this.kreirajClanaButton.UseVisualStyleBackColor = true;
            this.kreirajClanaButton.Click += new System.EventHandler(this.kreirajClanaButton_Click);
            // 
            // PretraziClanaButton
            // 
            this.PretraziClanaButton.Location = new System.Drawing.Point(37, 80);
            this.PretraziClanaButton.Name = "PretraziClanaButton";
            this.PretraziClanaButton.Size = new System.Drawing.Size(178, 23);
            this.PretraziClanaButton.TabIndex = 1;
            this.PretraziClanaButton.Text = "Pretrazi Clana";
            this.PretraziClanaButton.UseVisualStyleBackColor = true;
            this.PretraziClanaButton.Click += new System.EventHandler(this.PretraziClanaButton_Click);
            // 
            // PorukaUlogovanoglabel
            // 
            this.PorukaUlogovanoglabel.AutoSize = true;
            this.PorukaUlogovanoglabel.Location = new System.Drawing.Point(34, 20);
            this.PorukaUlogovanoglabel.Name = "PorukaUlogovanoglabel";
            this.PorukaUlogovanoglabel.Size = new System.Drawing.Size(56, 16);
            this.PorukaUlogovanoglabel.TabIndex = 2;
            this.PorukaUlogovanoglabel.Text = "Zdravo, ";
            // 
            // KreirajTreneraButton
            // 
            this.KreirajTreneraButton.Location = new System.Drawing.Point(387, 51);
            this.KreirajTreneraButton.Name = "KreirajTreneraButton";
            this.KreirajTreneraButton.Size = new System.Drawing.Size(178, 23);
            this.KreirajTreneraButton.TabIndex = 3;
            this.KreirajTreneraButton.Text = "Kreiraj Trenera";
            this.KreirajTreneraButton.UseVisualStyleBackColor = true;
            this.KreirajTreneraButton.Click += new System.EventHandler(this.KreirajTreneraButton_Click);
            // 
            // PretraziTreneraButton
            // 
            this.PretraziTreneraButton.Location = new System.Drawing.Point(387, 80);
            this.PretraziTreneraButton.Name = "PretraziTreneraButton";
            this.PretraziTreneraButton.Size = new System.Drawing.Size(178, 23);
            this.PretraziTreneraButton.TabIndex = 4;
            this.PretraziTreneraButton.Text = "Pretrazi Trenera";
            this.PretraziTreneraButton.UseVisualStyleBackColor = true;
            this.PretraziTreneraButton.Click += new System.EventHandler(this.PretraziTreneraButton_Click);
            // 
            // PlanKreirajButton1
            // 
            this.PlanKreirajButton1.Location = new System.Drawing.Point(717, 51);
            this.PlanKreirajButton1.Name = "PlanKreirajButton1";
            this.PlanKreirajButton1.Size = new System.Drawing.Size(228, 23);
            this.PlanKreirajButton1.TabIndex = 5;
            this.PlanKreirajButton1.Text = "Kreiraj plan treninga";
            this.PlanKreirajButton1.UseVisualStyleBackColor = true;
            this.PlanKreirajButton1.Click += new System.EventHandler(this.PlanKreirajButton1_Click);
            // 
            // IzmeniPlanButton1
            // 
            this.IzmeniPlanButton1.Location = new System.Drawing.Point(717, 80);
            this.IzmeniPlanButton1.Name = "IzmeniPlanButton1";
            this.IzmeniPlanButton1.Size = new System.Drawing.Size(228, 23);
            this.IzmeniPlanButton1.TabIndex = 6;
            this.IzmeniPlanButton1.Text = "Izmeni plan treninga";
            this.IzmeniPlanButton1.UseVisualStyleBackColor = true;
            this.IzmeniPlanButton1.Click += new System.EventHandler(this.IzmeniPlanButton1_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.Location = new System.Drawing.Point(12, 109);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(980, 794);
            this.MainPanel.TabIndex = 7;
            // 
            // GlavnaEkranskaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1004, 915);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.IzmeniPlanButton1);
            this.Controls.Add(this.PlanKreirajButton1);
            this.Controls.Add(this.PretraziTreneraButton);
            this.Controls.Add(this.KreirajTreneraButton);
            this.Controls.Add(this.PorukaUlogovanoglabel);
            this.Controls.Add(this.PretraziClanaButton);
            this.Controls.Add(this.kreirajClanaButton);
            this.Name = "GlavnaEkranskaForma";
            this.Text = "GlavnaEkranskaForma";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button kreirajClanaButton;
        private System.Windows.Forms.Button PretraziClanaButton;
        private System.Windows.Forms.Label PorukaUlogovanoglabel;
        private System.Windows.Forms.Button KreirajTreneraButton;
        private System.Windows.Forms.Button PretraziTreneraButton;
        private System.Windows.Forms.Button PlanKreirajButton1;
        private System.Windows.Forms.Button IzmeniPlanButton1;
        private System.Windows.Forms.Panel MainPanel;
    }
}
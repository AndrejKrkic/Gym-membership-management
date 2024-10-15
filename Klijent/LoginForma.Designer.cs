namespace Klijent
{
    partial class LoginForma
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
            this.LoginButton = new System.Windows.Forms.Button();
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.obavezanUsernameLabel = new System.Windows.Forms.Label();
            this.ObavezanPasswordLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.Color.Tan;
            this.LoginButton.Location = new System.Drawing.Point(324, 183);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(106, 41);
            this.LoginButton.TabIndex = 0;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.Location = new System.Drawing.Point(177, 76);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(253, 22);
            this.UsernameTextBox.TabIndex = 1;
            this.UsernameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.UsernameTextBox.TextChanged += new System.EventHandler(this.UsernameTextBox_TextChanged);
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(177, 125);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(253, 22);
            this.PasswordTextBox.TabIndex = 2;
            this.PasswordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PasswordTextBox.TextChanged += new System.EventHandler(this.PasswordTextBox_TextChanged);
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLabel.Location = new System.Drawing.Point(63, 76);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(108, 25);
            this.UsernameLabel.TabIndex = 3;
            this.UsernameLabel.Text = "Username:";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.Location = new System.Drawing.Point(67, 125);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(104, 25);
            this.PasswordLabel.TabIndex = 4;
            this.PasswordLabel.Text = "Password:";
            // 
            // obavezanUsernameLabel
            // 
            this.obavezanUsernameLabel.AutoSize = true;
            this.obavezanUsernameLabel.ForeColor = System.Drawing.Color.IndianRed;
            this.obavezanUsernameLabel.Location = new System.Drawing.Point(436, 79);
            this.obavezanUsernameLabel.Name = "obavezanUsernameLabel";
            this.obavezanUsernameLabel.Size = new System.Drawing.Size(105, 16);
            this.obavezanUsernameLabel.TabIndex = 5;
            this.obavezanUsernameLabel.Text = "Obavezno polje!";
            this.obavezanUsernameLabel.Visible = false;
            // 
            // ObavezanPasswordLabel
            // 
            this.ObavezanPasswordLabel.AutoSize = true;
            this.ObavezanPasswordLabel.ForeColor = System.Drawing.Color.IndianRed;
            this.ObavezanPasswordLabel.Location = new System.Drawing.Point(436, 131);
            this.ObavezanPasswordLabel.Name = "ObavezanPasswordLabel";
            this.ObavezanPasswordLabel.Size = new System.Drawing.Size(105, 16);
            this.ObavezanPasswordLabel.TabIndex = 6;
            this.ObavezanPasswordLabel.Text = "Obavezno polje!";
            this.ObavezanPasswordLabel.Visible = false;
            // 
            // LoginForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(598, 450);
            this.Controls.Add(this.ObavezanPasswordLabel);
            this.Controls.Add(this.obavezanUsernameLabel);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.UsernameTextBox);
            this.Controls.Add(this.LoginButton);
            this.Name = "LoginForma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForma";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Label PasswordLabel;
        public System.Windows.Forms.Button LoginButton;
        public System.Windows.Forms.TextBox UsernameTextBox;
        public System.Windows.Forms.TextBox PasswordTextBox;
        public System.Windows.Forms.Label obavezanUsernameLabel;
        public System.Windows.Forms.Label ObavezanPasswordLabel;
    }
}
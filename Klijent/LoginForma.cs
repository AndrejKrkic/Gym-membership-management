using Klijent.GuiController;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klijent
{
    public partial class LoginForma : Form
    {
        public LoginForma()
        {
            InitializeComponent();
            LoginGuiController.Instance.Connect(this);
            LoginButton.Click += LoginGuiController.Instance.Login;
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            //LoginGuiController.Instance.Login();
        }

        private void UsernameTextBox_TextChanged(object sender, EventArgs e)
        {
            UsernameTextBox.BackColor = Color.White;
            obavezanUsernameLabel.Visible = false;
        }

        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            PasswordTextBox.BackColor = Color.White;
            ObavezanPasswordLabel.Visible = false;
        }
    }
}

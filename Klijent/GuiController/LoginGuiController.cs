using Common;
using Common.Domain;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klijent.GuiController
{
    public class LoginGuiController
    {
        private static LoginGuiController instance;
        public static LoginGuiController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LoginGuiController();
                }
                return instance;
            }
        }
        private LoginGuiController()
        {
        }

        private LoginForma loginForma;

        public void Connect(LoginForma loginForma)
        {
            this.loginForma = loginForma;
            if (!Communication.Instance.Connect())
            {
                MessageBox.Show("Klijent ne moze da se poveze na server!");
                Environment.Exit(0);
            }
        }

        public void Login(object sender, EventArgs e)
        {
            bool validacija = true;
            if (String.IsNullOrEmpty(loginForma.UsernameTextBox.Text))
            {
                loginForma.obavezanUsernameLabel.Visible = true;
                loginForma.UsernameTextBox.BackColor = Color.Red;
                validacija = false;
            }

            if (String.IsNullOrEmpty(loginForma.PasswordTextBox.Text))
            {
                loginForma.ObavezanPasswordLabel.Visible = true;
                loginForma.PasswordTextBox.BackColor = Color.Red;
                validacija = false;
            }
            if (!validacija)
                return;

            Korisnik korisnik = new Korisnik();
            korisnik.Username = loginForma.UsernameTextBox.Text;
            korisnik.Password = loginForma.PasswordTextBox.Text;

            Response response = Communication.Instance.Login(korisnik);

            if (response.Result != null)
            {
                MessageBox.Show("Uspesno ste se ulogovali.");
                Korisnik ulogovanKorisnik = (Korisnik)response.Result;
                GlavnaEkranskaForma glavnaEkranskaForma = new GlavnaEkranskaForma(ulogovanKorisnik.Ime);
                glavnaEkranskaForma.Show();
                loginForma.Hide();
            }
            else
            {
                MessageBox.Show("Neuspesan login.");
            }

        }

    }
}

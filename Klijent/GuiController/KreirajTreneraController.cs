using Common.Domain;
using Common;
using Klijent.UserControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Drawing;

namespace Klijent.GuiController
{
    public class KreirajTreneraController
    {
        private UCKreirajTrenera kreirajTrenera; //INSTANCIRA FORMU
        internal System.Windows.Forms.Control NapraviDodajTreneraFormu()
        {
            kreirajTrenera = new UCKreirajTrenera();
            kreirajTrenera.ZapamtiButton1.Click += KreirajTrenera;
            return kreirajTrenera;
        }

        private void KreirajTrenera(object sender, EventArgs e)
        {

            bool validacija = true;
            if (String.IsNullOrEmpty(kreirajTrenera.ImetextBox1.Text) || kreirajTrenera.ImetextBox1.Text.Length > 50)
            {
                kreirajTrenera.ImetextBox1.BackColor = Color.Red;
                validacija = false;
            }
            if (String.IsNullOrEmpty(kreirajTrenera.PrezimetextBox2.Text) || kreirajTrenera.PrezimetextBox2.Text.Length > 50)
            {
                kreirajTrenera.PrezimetextBox2.BackColor = Color.Red;
                validacija = false;
            }
            if (String.IsNullOrEmpty(kreirajTrenera.AdresatextBox3.Text) || kreirajTrenera.AdresatextBox3.Text.Length > 50)
            {
                kreirajTrenera.AdresatextBox3.BackColor = Color.Red;
                validacija = false;
            }

            if (!validacija)
                return;

            string ime = kreirajTrenera.ImetextBox1.Text;
            string prezime = kreirajTrenera.PrezimetextBox2.Text;
            string adresa = kreirajTrenera.AdresatextBox3.Text;
            Response response = Communication.Instance.KreirajTrenera(ime, prezime, adresa);

            if (response.Exception == null)
            {
                MessageBox.Show("Sistem je zapamtio trenera.");
                //this.Close();
            }
            else
            {
                MessageBox.Show("Sistem ne moze da zapamti trenera.");
            }
        }

    }
}

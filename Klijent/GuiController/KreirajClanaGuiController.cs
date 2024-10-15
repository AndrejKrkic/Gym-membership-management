using Common;
using Common.Domain;
using Klijent.UserControls;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klijent.GuiController
{
    public class KreirajClanaGuiController
    {

        private UCKreirajClana kreirajClana; //INSTANCIRA FORMU
        internal Control NapraviDodajClanaFormu()
        {
            kreirajClana = new UCKreirajClana();
            kreirajClana.KreirajButton.Click += KreirajClana;
            return kreirajClana;
        }

        private void KreirajClana(object sender, EventArgs e)
        {
            bool validacija = true;
            int meseciIskustva = 0;
            if (String.IsNullOrEmpty(kreirajClana.ImeTextBox1.Text) || kreirajClana.ImeTextBox1.Text.Length > 50)
            {
                kreirajClana.ImeTextBox1.BackColor = Color.Red;
                validacija = false;
            }
            if (String.IsNullOrEmpty(kreirajClana.PrezimeTextBox.Text) || kreirajClana.PrezimeTextBox.Text.Length > 50)
            {
                kreirajClana.PrezimeTextBox.BackColor = Color.Red;
                validacija = false;
            }
            if (String.IsNullOrEmpty(kreirajClana.MeseciIksustvaTextBox.Text) || !int.TryParse(kreirajClana.MeseciIksustvaTextBox.Text, out meseciIskustva) || meseciIskustva < 0)
            {
                kreirajClana.MeseciIksustvaTextBox.BackColor = Color.Red;
                validacija = false;
            }
            if (kreirajClana.MestoComboBox.SelectedIndex == -1)
            {
                kreirajClana.MestoComboBox.BackColor = Color.Red;
                validacija = false;
            }

            if (!validacija)
                return;

            string ime = kreirajClana.ImeTextBox1.Text;
            string prezime = kreirajClana.PrezimeTextBox.Text;
            Mesto mesto = kreirajClana.mesta[kreirajClana.MestoComboBox.SelectedIndex];
            Response response = Communication.Instance.KreirajClana(ime, prezime, meseciIskustva, mesto);

            if (response.Exception == null)
            {
                MessageBox.Show("Sistem je zapamtio clana.");
                //this.Close();
            }
            else
            {
                MessageBox.Show("Sistem ne moze da zapamti clana.");
            }


        }


    }
}

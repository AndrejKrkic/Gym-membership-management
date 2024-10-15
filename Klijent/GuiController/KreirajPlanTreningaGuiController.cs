using Common.Domain;
using Common;
using Klijent.UserControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Klijent.GuiController
{
    public class KreirajPlanTreningaGuiController
    {
       
        private UCKreirajPlanTreninga kreirajPlan; //INSTANCIRA FORMU
        internal Control NapraviKreirajPlanFormu()
        {
            kreirajPlan = new UCKreirajPlanTreninga();
            kreirajPlan.KreirajPlanButton3.Click += KreirajPlan;
            kreirajPlan.DodajVezbuButton1.Click += DodajVezbuButton1;
            kreirajPlan.ObrisiVezbuButton2.Click += ObrisiVezbuButton2;
            return kreirajPlan;
        }

        private void KreirajPlan(object sender, EventArgs e)
        {
            bool validacija = true;
            int trajanje = 0;
            if (kreirajPlan.TrenerComboBox1.SelectedIndex == -1)
            {
                kreirajPlan.TrenerComboBox1.BackColor = Color.Red;
                validacija = false;
            }
            if (kreirajPlan.ClanComboBox2.SelectedIndex == -1)
            {
                kreirajPlan.ClanComboBox2.BackColor = Color.Red;
                validacija = false;
            }
            if (String.IsNullOrEmpty(kreirajPlan.NazivTextBox1.Text) || kreirajPlan.NazivTextBox1.Text.Length > 50)
            {
                kreirajPlan.NazivTextBox1.BackColor = Color.Red;
                validacija = false;
            }
            if (String.IsNullOrEmpty(kreirajPlan.TrajanjeTextBox2.Text) || !int.TryParse(kreirajPlan.TrajanjeTextBox2.Text, out trajanje) || trajanje < 0)
            {
                kreirajPlan.TrajanjeTextBox2.BackColor = Color.Red;
                validacija = false;
            }


            if (!validacija)
                return;


            Plan plan = new Plan();
            plan.Clan = kreirajPlan.clanovi[kreirajPlan.ClanComboBox2.SelectedIndex];
            plan.Trener = kreirajPlan.treneri[kreirajPlan.TrenerComboBox1.SelectedIndex];
            plan.Trajanje = int.Parse(kreirajPlan.TrajanjeTextBox2.Text);
            plan.Naziv = kreirajPlan.NazivTextBox1.Text;
            plan.Opis = kreirajPlan.OpisRichTextBox1.Text;


            foreach (StavkaPlana stavka in kreirajPlan.stavkePlana)
            {
                stavka.Trener = kreirajPlan.treneri[kreirajPlan.TrenerComboBox1.SelectedIndex];
                stavka.Clan = kreirajPlan.clanovi[kreirajPlan.ClanComboBox2.SelectedIndex];
            }

            Response response = Communication.Instance.KreirajPlan(plan, kreirajPlan.stavkePlana);

            if (response.Exception == null)
            {
                MessageBox.Show("Sistem je zapamtio plan.");
                //this.Close();
            }
            else
            {
                MessageBox.Show("Sistem ne moze da zapamti plan.");
            }
        }

        private void DodajVezbuButton1(object sender, EventArgs e)
        {
            bool validacija = true;
            int brPon = 0;
            int brSer = 0;
            if (kreirajPlan.VezbaComboBox3.SelectedIndex == -1)
            {
                kreirajPlan.VezbaComboBox3.BackColor = Color.Red;
                validacija = false;
            }
            if (String.IsNullOrEmpty(kreirajPlan.BrPonavljanjaTextBox3.Text) || !int.TryParse(kreirajPlan.BrPonavljanjaTextBox3.Text, out brPon) || brPon < 0)
            {
                kreirajPlan.BrPonavljanjaTextBox3.BackColor = Color.Red;
                validacija = false;
            }
            if (String.IsNullOrEmpty(kreirajPlan.BrSerijaTextBox4.Text) || !int.TryParse(kreirajPlan.BrSerijaTextBox4.Text, out brSer) || brSer < 0)
            {
                kreirajPlan.BrSerijaTextBox4.BackColor = Color.Red;
                validacija = false;
            }

            if (!validacija)
                return;


            StavkaPlana stavkaPlana = new StavkaPlana();
            stavkaPlana.BrojPonavljanja = int.Parse(kreirajPlan.BrPonavljanjaTextBox3.Text);
            stavkaPlana.BrojSerija = int.Parse(kreirajPlan.BrSerijaTextBox4.Text);
            stavkaPlana.Vezba = kreirajPlan.vezbe[kreirajPlan.VezbaComboBox3.SelectedIndex];
            kreirajPlan.stavkePlana.Add(stavkaPlana);

            //---------


            kreirajPlan.VezbeDGV.DataSource = null;
            kreirajPlan.VezbeDGV.DataSource = kreirajPlan.stavkePlana;
        }


        private void ObrisiVezbuButton2(object sender, EventArgs e)
        {


            if (kreirajPlan.VezbeDGV.CurrentCell == null)
            {
                return;
            }

            //Console.WriteLine(">>>>>>>" +VezbeDGV.SelectedCells.Count);
            //Console.WriteLine(VezbeDGV.SelectedRows.Count);
            //Console.WriteLine(VezbeDGV.CurrentCell.RowIndex);

            //int index = VezbeDGV.CurrentCell.RowIndex;
            if (kreirajPlan.stavkePlana.Count == 0)
            {
                return;
            }



            //================
            int index = kreirajPlan.VezbeDGV.CurrentCell.RowIndex;
            StavkaPlana selektovanaStavka = kreirajPlan.stavkePlana[index];
            kreirajPlan.stavkePlana.Remove(selektovanaStavka);
            kreirajPlan.VezbeDGV.DataSource = null;
            kreirajPlan.VezbeDGV.DataSource = kreirajPlan.stavkePlana;
        }


    }
}

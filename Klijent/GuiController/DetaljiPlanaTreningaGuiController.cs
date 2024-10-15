using Common;
using Common.Domain;
using Klijent.UserControls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klijent.GuiController
{
    public class DetaljiPlanaTreningaGuiController
    {
        private UCDetaljiPlanaTreninga detaljiPlana; //INSTANCIRA FORMU
        internal Control NapraviDetaljiPlanFormu(Plan plan)
        {
            detaljiPlana = new UCDetaljiPlanaTreninga(plan);
            detaljiPlana.SacuvajPlanButton3.Click += SacuvajPlanButton3_Click;
            detaljiPlana.DodajVezbuButton1.Click += DodajVezbuButton1_Click;
            detaljiPlana.ObrisiVezbuButton2.Click += ObrisiVezbuButton2_Click;
            return detaljiPlana;
        }

        private void SacuvajPlanButton3_Click(object sender, EventArgs e)
        {
            bool validacija = true;
            int trajanje = 0;

            if (String.IsNullOrEmpty(detaljiPlana.NazivTextBox1.Text) || detaljiPlana.NazivTextBox1.Text.Length > 50)
            {
                detaljiPlana.NazivTextBox1.BackColor = Color.Red;
                validacija = false;
            }
            if (String.IsNullOrEmpty(detaljiPlana.TrajanjeTextBox2.Text) || !int.TryParse(detaljiPlana.TrajanjeTextBox2.Text, out trajanje) || trajanje < 0)
            {
                detaljiPlana.TrajanjeTextBox2.BackColor = Color.Red;
                validacija = false;
            }


            if (!validacija)
                return;


            Plan plan = new Plan();
            plan.Clan = new Clan();
            plan.Trener = new Trener();
            plan.Clan.ClanId = detaljiPlana.clanID;
            plan.Trener.TrenerID = detaljiPlana.trenerID;
            plan.Trajanje = int.Parse(detaljiPlana.TrajanjeTextBox2.Text);
            plan.Naziv = detaljiPlana.NazivTextBox1.Text;
            plan.Opis = detaljiPlana.OpisRichTextBox1.Text;


            foreach (StavkaPlana stavka in detaljiPlana.stavkePlana)
            {
                stavka.Clan = new Clan();
                stavka.Trener = new Trener();
                stavka.Trener.TrenerID = detaljiPlana.trenerID;
                stavka.Clan.ClanId = detaljiPlana.clanID;
            }

            Response response = Communication.Instance.IzmeniPlan(plan, detaljiPlana.stavkePlana, detaljiPlana.stavkePlanaZaBrisanje);

            if (response.Exception == null)
            {
                MessageBox.Show("Sistem je zapamtio plan.");
                //this.Close();
                MainCoordinator.Instance.PrikaziPretraziPlanPanel();
            }
            else
            {
                MessageBox.Show("Sistem ne moze da zapamti plan.");
            }
        }

        private void DodajVezbuButton1_Click(object sender, EventArgs e)
        {
            bool validacija = true;
            int brPon = 0;
            int brSer = 0;
            if (detaljiPlana.VezbaComboBox3.SelectedIndex == -1)
            {
                detaljiPlana.VezbaComboBox3.BackColor = Color.Red;
                validacija = false;
            }
            if (String.IsNullOrEmpty(detaljiPlana.BrPonavljanjaTextBox3.Text) || !int.TryParse(detaljiPlana.BrPonavljanjaTextBox3.Text, out brPon) || brPon < 0)
            {
                detaljiPlana.BrPonavljanjaTextBox3.BackColor = Color.Red;
                validacija = false;
            }
            if (String.IsNullOrEmpty(detaljiPlana.BrSerijaTextBox4.Text) || !int.TryParse(detaljiPlana.BrSerijaTextBox4.Text, out brSer) || brSer < 0)
            {
                detaljiPlana.BrSerijaTextBox4.BackColor = Color.Red;
                validacija = false;
            }

            if (!validacija)
                return;


            StavkaPlana stavkaPlana = new StavkaPlana();
            stavkaPlana.BrojPonavljanja = int.Parse(detaljiPlana.BrPonavljanjaTextBox3.Text);
            stavkaPlana.BrojSerija = int.Parse(detaljiPlana.BrSerijaTextBox4.Text);
            stavkaPlana.Vezba = detaljiPlana.vezbe[detaljiPlana.VezbaComboBox3.SelectedIndex];
            stavkaPlana.Status = Status.Added;
            detaljiPlana.stavkePlana.Add(stavkaPlana);

            OsveziDGV();
        }

        private void ObrisiVezbuButton2_Click(object sender, EventArgs e)
        {
            try
            {
                if (detaljiPlana.VezbeDGV.CurrentCell == null)
                {
                    return;
                }

                //Console.WriteLine(">>>>>>>" +VezbeDGV.SelectedCells.Count);
                //Console.WriteLine(VezbeDGV.SelectedRows.Count);
                //Console.WriteLine(VezbeDGV.CurrentCell.RowIndex);

                int index = detaljiPlana.VezbeDGV.CurrentCell.RowIndex;
                if (detaljiPlana.stavkePlana.Count == 0)
                {
                    return;
                }
                StavkaPlana selektovanaStavka = detaljiPlana.stavkePlana[index];


                detaljiPlana.stavkePlana[index].Status = Status.Removed;

                selektovanaStavka.Trener = new Trener();
                selektovanaStavka.Clan = new Clan();
                selektovanaStavka.Trener.TrenerID = detaljiPlana.trenerID;
                selektovanaStavka.Clan.ClanId = detaljiPlana.clanID;
                detaljiPlana.stavkePlanaZaBrisanje.Add(selektovanaStavka);
                detaljiPlana.stavkePlana.Remove(selektovanaStavka);



                OsveziDGV();
            }
            catch (Exception)
            {
                throw new Exception();

            }

        }
        private void OsveziDGV()
        {
            detaljiPlana.VezbeDGV.DataSource = null;
            detaljiPlana.VezbeDGV.DataSource = detaljiPlana.stavkePlana;
        }
    }
}

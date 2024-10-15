using Common;
using Common.Domain;
using Klijent.UserControls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klijent.GuiController
{
    public class DetaljiTreneraGuiController
    {
        private UCDetaljiTrenera detaljiTrenera; //INSTANCIRA FORMU
        internal Control NapraviDetaljiTreneraFormu(Trener trener)
        {
            detaljiTrenera = new UCDetaljiTrenera(trener);
            detaljiTrenera.OdustaniButton.Click += OdustaniButton_Click;
            detaljiTrenera.IzmeniButton.Click += IzmeniButton_Click;
            detaljiTrenera.ObrisiButton.Click += ObrisiButton_Click;
            return detaljiTrenera;
        }


        private void OdustaniButton_Click(object sender, EventArgs e)
        {
            MainCoordinator.Instance.PrikaziPretraziTreneraPanel();
        }

        private void IzmeniButton_Click(object sender, EventArgs e)
        {
            bool validacija = true;
            if (String.IsNullOrEmpty(detaljiTrenera.AdresaTextBox1.Text) || detaljiTrenera.AdresaTextBox1.Text.Length > 50)
            {
                detaljiTrenera.AdresaTextBox1.BackColor = Color.Red;
                validacija = false;
            }

            if (!validacija)
                return;

            Trener izmenjenTrener = new Trener();
            izmenjenTrener.TrenerID = detaljiTrenera.trenerID;
            izmenjenTrener.Ime = detaljiTrenera.ImetextBox1.Text;
            izmenjenTrener.Prezime = detaljiTrenera.PrezimetextBox2.Text;
            izmenjenTrener.Adresa = detaljiTrenera.AdresaTextBox1.Text;
            Response response = Communication.Instance.IzmeniTrenera(izmenjenTrener);
            if (response.Exception == null)
            {
                MessageBox.Show("Uspesno ste izmenili trenera.");
                //this.Close();
                MainCoordinator.Instance.PrikaziPretraziTreneraPanel();
            }
            else
            {
                MessageBox.Show("Sistem ne moze da izmeni trenera.");
            }
        }

        private void ObrisiButton_Click(object sender, EventArgs e)
        {
            Trener trener = new Trener();
            trener.TrenerID = detaljiTrenera.trenerID;
            Response response = Communication.Instance.ObrisiTrenera(trener);
            if (response.Exception == null)
            {
                MessageBox.Show("Uspesno ste obrisali trenera.");
                //this.Close();
                MainCoordinator.Instance.PrikaziPretraziTreneraPanel();
            }
            else
            {
                MessageBox.Show("Sistem ne moze da obrise trenera.");
            }
        }
    }
}

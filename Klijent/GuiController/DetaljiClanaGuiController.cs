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
    public class DetaljiClanaGuiController
    {

        private UCDetaljiClana detaljiClana; //INSTANCIRA FORMU
        internal Control NapraviDetaljiClanaFormu(Clan clan)
        {
            detaljiClana = new UCDetaljiClana(clan);
            detaljiClana.OdustaniButton.Click += OdustaniButton_Click;
            detaljiClana.IzmeniButton.Click += IzmeniButton_Click;
            detaljiClana.ObrisiButton.Click += ObrisiButton_Click;
            return detaljiClana;
        }

        private void OdustaniButton_Click(object sender, EventArgs e)
        {
            MainCoordinator.Instance.PrikaziPretraziClanaPanel();
        }

        private void IzmeniButton_Click(object sender, EventArgs e)
        {
            bool validacija = true;
            int meseciIskustva = 0;
            if (String.IsNullOrEmpty(detaljiClana.IskustvotextBox3.Text) || !int.TryParse(detaljiClana.IskustvotextBox3.Text, out meseciIskustva) || meseciIskustva < 0)
            {
                detaljiClana.IskustvotextBox3.BackColor = Color.Red;
                validacija = false;
            }
            if (detaljiClana.MestocomboBox1.SelectedIndex == -1)
            {
                detaljiClana.MestocomboBox1.BackColor = Color.Red;
                validacija = false;
            }

            if (!validacija)
                return;

            Clan izmenjenClan = new Clan();
            izmenjenClan.ClanId = detaljiClana.clanID;
            izmenjenClan.Ime = detaljiClana.ImetextBox1.Text;
            izmenjenClan.Prezime = detaljiClana.PrezimetextBox2.Text;
            izmenjenClan.MeseciIskustva = int.Parse(detaljiClana.IskustvotextBox3.Text);
            izmenjenClan.Mesto = detaljiClana.mesta[detaljiClana.MestocomboBox1.SelectedIndex]; //proveriti ovooo
            Response response = Communication.Instance.IzmeniClana(izmenjenClan);
            if (response.Exception == null)
            {
                MessageBox.Show("Uspesno ste izmenili clana.");
                //this.Close();
                MainCoordinator.Instance.PrikaziPretraziClanaPanel();
            }
            else
            {
                MessageBox.Show("Sistem ne moze da izmeni clana.");
            }
        }

        private void ObrisiButton_Click(object sender, EventArgs e)
        {
            Clan clan = new Clan();
            clan.ClanId = detaljiClana.clanID;
            Response response = Communication.Instance.ObrisiClana(clan);
            if (response.Exception == null)
            {
                MessageBox.Show("Uspesno ste obrisali clana.");
                //this.Close();
                MainCoordinator.Instance.PrikaziPretraziClanaPanel();
            }
            else
            {
                MessageBox.Show("Sistem ne moze da obrise clana.");
            }
        }
    }
}

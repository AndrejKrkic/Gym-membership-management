using Common.Domain;
using Common;
using Klijent.UserControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;

namespace Klijent.GuiController
{
    public class PretraziClanaGuiController
    {
        private UCPretraziClana pretraziClana; //INSTANCIRA FORMU
        internal Control NapraviPretraziClanaFormu()
        {
            pretraziClana = new UCPretraziClana();
            pretraziClana.PretraziButton.Click += PretraziClana;
            pretraziClana.DetaljiButton.Click += DetaljiButton;
            return pretraziClana;
        }

        private void PretraziClana(object sender, EventArgs e)
        {
            pretraziClana.clanovi = new BindingList<Clan>(Communication.Instance.PretraziClanove(pretraziClana.PretragaTextBox.Text));
            if (pretraziClana.clanovi.Count == 0)
                MessageBox.Show("Sistem ne moze da nadje clanove po zadatoj vrednosti.");
            else
            {
                OsveziDGV();
            }

        }

        private void DetaljiButton(object sender, EventArgs e)
        {
            if (pretraziClana.clanovi.Count == 0)
                return;
            int index = pretraziClana.ClanoviDGV.CurrentCell.RowIndex;
            Clan selektovanClan = pretraziClana.clanovi[index];

            //FormDetaljiClana formDetaljiClana = new FormDetaljiClana(selektovanClan);
            //formDetaljiClana.ShowDialog();
            MainCoordinator.Instance.PrikaziDetaljiClanaPanel(selektovanClan);

            //ovo ce morati kad se vrati
            //pretraziClana.clanovi = new BindingList<Clan>(Communication.Instance.PretraziClanove(pretraziClana.PretragaTextBox.Text));

            //OsveziDGV();

        }

        private void OsveziDGV()
        {

            pretraziClana.ClanoviDGV.DataSource = null;
            pretraziClana.ClanoviDGV.DataSource = pretraziClana.clanovi;
        }


    }
}

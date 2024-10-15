using Common.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klijent.UserControls
{
    public partial class UCDetaljiClana : UserControl
    {
        public List<Mesto> mesta;
        public int clanID;
        public UCDetaljiClana(Clan selektovanClan)
        {
            InitializeComponent();
            clanID = selektovanClan.ClanId;
            IDLabel.Text += " " + clanID;
            ImetextBox1.Text = selektovanClan.Ime;
            PrezimetextBox2.Text = selektovanClan.Prezime;
            IskustvotextBox3.Text = selektovanClan.MeseciIskustva.ToString();

            mesta = Communication.Instance.UcitajListuMesta();
            foreach (Mesto mesto in mesta)
            {
                MestocomboBox1.Items.Add(mesto.Naziv);
            }
            MestocomboBox1.SelectedItem = selektovanClan.Mesto.Naziv;
        }

        private void IskustvotextBox3_TextChanged(object sender, EventArgs e)
        {
            IskustvotextBox3.BackColor = Color.White;
        }

        private void MestocomboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MestocomboBox1.BackColor = Color.White;
        }
    }
}

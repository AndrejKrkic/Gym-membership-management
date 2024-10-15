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
    public partial class UCDetaljiTrenera : UserControl
    {
        public int trenerID;
        public UCDetaljiTrenera(Trener selektovanTrener)
        {
            InitializeComponent();
            trenerID = selektovanTrener.TrenerID;
            IDLabel.Text += " " + trenerID;
            ImetextBox1.Text = selektovanTrener.Ime;
            PrezimetextBox2.Text = selektovanTrener.Prezime;
            AdresaTextBox1.Text = selektovanTrener.Adresa;
        }

        private void AdresaTextBox1_TextChanged(object sender, EventArgs e)
        {
            AdresaTextBox1.BackColor = Color.White;
        }
    }
}

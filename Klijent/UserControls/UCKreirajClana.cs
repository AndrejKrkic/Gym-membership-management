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
    public partial class UCKreirajClana : UserControl
    {
        public List<Mesto> mesta;
        public UCKreirajClana()
        {
            InitializeComponent();
            mesta = Communication.Instance.UcitajListuMesta();
            foreach (Mesto mesto in mesta)
            {
                MestoComboBox.Items.Add(mesto.Naziv);
            }
        }



        private void ImeTextBox1_TextChanged_1(object sender, EventArgs e)
        {
            ImeTextBox1.BackColor = Color.White;
        }

        private void PrezimeTextBox_TextChanged_1(object sender, EventArgs e)
        {
            PrezimeTextBox.BackColor = Color.White;
        }

        private void MeseciIksustvaTextBox_TextChanged_1(object sender, EventArgs e)
        {
            MeseciIksustvaTextBox.BackColor = Color.White;
        }

        private void MestoComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            MestoComboBox.BackColor = Color.White;
        }
    }
}

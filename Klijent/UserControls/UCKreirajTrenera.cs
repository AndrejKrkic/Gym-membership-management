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
    public partial class UCKreirajTrenera : UserControl
    {
        public UCKreirajTrenera()
        {
            InitializeComponent();
        }

        private void ImetextBox1_TextChanged(object sender, EventArgs e)
        {
            ImetextBox1.BackColor = Color.White;
        }

        private void PrezimetextBox2_TextChanged(object sender, EventArgs e)
        {
            PrezimetextBox2.BackColor = Color.White;
        }

        private void AdresatextBox3_TextChanged(object sender, EventArgs e)
        {
            AdresatextBox3.BackColor = Color.White;
        }
    }
}

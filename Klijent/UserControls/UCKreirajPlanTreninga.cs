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
    public partial class UCKreirajPlanTreninga : UserControl
    {
        public List<StavkaPlana> stavkePlana = new List<StavkaPlana>();
        public List<Vezba> vezbe;
        public List<Clan> clanovi;
        public List<Trener> treneri;
        public UCKreirajPlanTreninga()
        {
            InitializeComponent();
            treneri = Communication.Instance.UcitajListuTrenera();
            clanovi = Communication.Instance.UcitajListuClanova();
            vezbe = Communication.Instance.UcitajListuVezbi();

            foreach (Trener trener in treneri)
            {
                TrenerComboBox1.Items.Add(trener.Ime);
            }
            foreach (Clan clan in clanovi)
            {
                ClanComboBox2.Items.Add(clan.Ime);
            }
            foreach (Vezba vezba in vezbe)
            {
                VezbaComboBox3.Items.Add(vezba.Naziv);
            }

            VezbeDGV.AutoGenerateColumns = false;
            //VezbeDGV.DataSource = stavkePlana;

            DataGridViewTextBoxColumn dataGridViewColumn = new DataGridViewTextBoxColumn();
            dataGridViewColumn.Name = "Vezba";
            dataGridViewColumn.DataPropertyName = "Vezba";
            VezbeDGV.Columns.Add(dataGridViewColumn);

            DataGridViewTextBoxColumn dataGridViewColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewColumn2.Name = "Broj ponavljanja";
            dataGridViewColumn2.DataPropertyName = "BrojPonavljanja";
            VezbeDGV.Columns.Add(dataGridViewColumn2);

            DataGridViewTextBoxColumn dataGridViewColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewColumn3.Name = "Broj serija";
            dataGridViewColumn3.DataPropertyName = "BrojSerija";
            VezbeDGV.Columns.Add(dataGridViewColumn3);
        }


        private void ClanComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClanComboBox2.BackColor = Color.White;
        }

        private void NazivTextBox1_TextChanged(object sender, EventArgs e)
        {
            NazivTextBox1.BackColor = Color.White;
        }

        private void TrajanjeTextBox2_TextChanged(object sender, EventArgs e)
        {
            TrajanjeTextBox2.BackColor = Color.White;
        }

        private void VezbaComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            VezbaComboBox3.BackColor = Color.White;
        }

        private void BrPonavljanjaTextBox3_TextChanged(object sender, EventArgs e)
        {
            BrPonavljanjaTextBox3.BackColor = Color.White;
        }

        private void BrSerijaTextBox4_TextChanged(object sender, EventArgs e)
        {
            BrSerijaTextBox4.BackColor = Color.White;
        }

        private void TrenerComboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            TrenerComboBox1.BackColor = Color.White;
        }
    }
}

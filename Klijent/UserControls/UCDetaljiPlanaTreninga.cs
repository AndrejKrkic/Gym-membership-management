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
    public partial class UCDetaljiPlanaTreninga : UserControl
    {
        public List<StavkaPlana> stavkePlana;
        public List<StavkaPlana> stavkePlanaZaBrisanje = new List<StavkaPlana>();
        public List<Vezba> vezbe;
        public int trenerID, clanID;

        public UCDetaljiPlanaTreninga(Plan plan)
        {
            InitializeComponent();
            vezbe = Communication.Instance.UcitajListuVezbi();
            foreach (Vezba vezba in vezbe)
            {
                VezbaComboBox3.Items.Add(vezba.Naziv);
            }
            trenerID = plan.Trener.TrenerID;
            clanID = plan.Clan.ClanId;
            NazivTextBox1.Text = plan.Naziv;
            TrajanjeTextBox2.Text = plan.Trajanje.ToString();
            OpisRichTextBox1.Text = plan.Opis;
            TrenerTextBox1.Text = plan.Trener.Ime;
            ClanTextBox2.Text = plan.Clan.Ime;
            stavkePlana = Communication.Instance.UcitajListuStavkiPlanova(plan.Trener.TrenerID, plan.Clan.ClanId);

            VezbeDGV.AutoGenerateColumns = false;
            if (stavkePlana.Count > 0)
                VezbeDGV.DataSource = stavkePlana;

            DataGridViewTextBoxColumn dataGridViewColumn = new DataGridViewTextBoxColumn();
            dataGridViewColumn.Name = "Vezba";
            dataGridViewColumn.DataPropertyName = "Vezba";
            VezbeDGV.Columns.Add(dataGridViewColumn);

            DataGridViewTextBoxColumn dataGridViewColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewColumn2.Name = "Broj ponavljanja";
            dataGridViewColumn2.DataPropertyName = "BrojPonavljanja";
            VezbeDGV.Columns.Add(dataGridViewColumn2);

            DataGridViewTextBoxColumn dataGridViewColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewColumn3.Name = "BrojSerija";
            dataGridViewColumn3.DataPropertyName = "BrojSerija";
            VezbeDGV.Columns.Add(dataGridViewColumn3);
        }

        private void BrPonavljanjaTextBox3_TextChanged(object sender, EventArgs e)
        {
            BrPonavljanjaTextBox3.BackColor = Color.White;
        }

        private void BrSerijaTextBox4_TextChanged(object sender, EventArgs e)
        {
            BrSerijaTextBox4.BackColor = Color.White;
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

    }
}

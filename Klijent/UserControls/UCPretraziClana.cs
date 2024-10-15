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
    public partial class UCPretraziClana : UserControl
    {
        public BindingList<Clan> clanovi; //probaj binding listu
        public UCPretraziClana()
        {
            InitializeComponent();
            clanovi = new BindingList<Clan>(Communication.Instance.UcitajListuClanova());
            ClanoviDGV.AutoGenerateColumns = false;
            //VezbeDGV.DataSource = stavkePlana;

            DataGridViewTextBoxColumn dataGridViewColumn = new DataGridViewTextBoxColumn();
            dataGridViewColumn.Name = "Ime";
            dataGridViewColumn.DataPropertyName = "Ime";
            ClanoviDGV.Columns.Add(dataGridViewColumn);

            DataGridViewTextBoxColumn dataGridViewColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewColumn2.Name = "Prezime";
            dataGridViewColumn2.DataPropertyName = "Prezime";
            ClanoviDGV.Columns.Add(dataGridViewColumn2);

            DataGridViewTextBoxColumn dataGridViewColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewColumn3.Name = "MeseciIskustva";
            dataGridViewColumn3.DataPropertyName = "MeseciIskustva";
            ClanoviDGV.Columns.Add(dataGridViewColumn3);

            DataGridViewTextBoxColumn dataGridViewColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewColumn4.Name = "Mesto";
            dataGridViewColumn4.DataPropertyName = "Mesto";
            ClanoviDGV.Columns.Add(dataGridViewColumn4);
            ClanoviDGV.DataSource = null;
            ClanoviDGV.DataSource = clanovi;
        }
    }
}

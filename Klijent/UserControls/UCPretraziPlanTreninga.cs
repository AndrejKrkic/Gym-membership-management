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
    public partial class UCPretraziPlanTreninga : UserControl
    {
        public BindingList<Plan> planovi;
        public UCPretraziPlanTreninga()
        {
            InitializeComponent();
            planovi = new BindingList<Plan>(Communication.Instance.UcitajListuPlanova());


            PlanoviDGV.AutoGenerateColumns = false;
            if (planovi.Count > 0)
                PlanoviDGV.DataSource = planovi;

            DataGridViewTextBoxColumn dataGridViewColumn = new DataGridViewTextBoxColumn();
            dataGridViewColumn.Name = "Naziv";
            dataGridViewColumn.DataPropertyName = "Naziv";
            PlanoviDGV.Columns.Add(dataGridViewColumn);

            DataGridViewTextBoxColumn dataGridViewColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewColumn2.Name = "Trener";
            dataGridViewColumn2.DataPropertyName = "Trener";
            PlanoviDGV.Columns.Add(dataGridViewColumn2);

            DataGridViewTextBoxColumn dataGridViewColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewColumn3.Name = "Clan";
            dataGridViewColumn3.DataPropertyName = "Clan";
            PlanoviDGV.Columns.Add(dataGridViewColumn3);

            DataGridViewTextBoxColumn dataGridViewColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewColumn4.Name = "Trajanje";
            dataGridViewColumn4.DataPropertyName = "Trajanje";
            PlanoviDGV.Columns.Add(dataGridViewColumn4);

            DataGridViewTextBoxColumn dataGridViewColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewColumn5.Name = "Opis";
            dataGridViewColumn5.DataPropertyName = "Opis";
            PlanoviDGV.Columns.Add(dataGridViewColumn5);
        }
    }
}

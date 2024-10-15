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
    public partial class UCPretraziTrenera : UserControl
    {
        public BindingList<Trener> treneri;
        public UCPretraziTrenera()
        {
            InitializeComponent();
            treneri = new BindingList<Trener>(Communication.Instance.UcitajListuTrenera());

            TreneriDGV.AutoGenerateColumns = false;
            if (treneri.Count > 0)
                TreneriDGV.DataSource = treneri;

            DataGridViewTextBoxColumn dataGridViewColumn = new DataGridViewTextBoxColumn();
            dataGridViewColumn.Name = "Ime";
            dataGridViewColumn.DataPropertyName = "Ime";
            TreneriDGV.Columns.Add(dataGridViewColumn);

            DataGridViewTextBoxColumn dataGridViewColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewColumn2.Name = "Prezime";
            dataGridViewColumn2.DataPropertyName = "Prezime";
            TreneriDGV.Columns.Add(dataGridViewColumn2);

            DataGridViewTextBoxColumn dataGridViewColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewColumn3.Name = "Adresa";
            dataGridViewColumn3.DataPropertyName = "Adresa";
            TreneriDGV.Columns.Add(dataGridViewColumn3);


        }
    }
}

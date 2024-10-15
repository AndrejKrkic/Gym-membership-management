using Common.Domain;
using Klijent.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klijent.GuiController
{
    public class PretraziPlanTreningaGuiController
    {

        private UCPretraziPlanTreninga pretraziPlan; //INSTANCIRA FORMU
        internal Control NapraviPretraziPlanFormu()
        {
            pretraziPlan = new UCPretraziPlanTreninga();
            pretraziPlan.PretraziButton1.Click += PretraziButton1;
            pretraziPlan.IzmeniButton2.Click += IzmeniButton2_Click;
            return pretraziPlan;
        }

        private void IzmeniButton2_Click(object sender, EventArgs e)
        {
            if (pretraziPlan.planovi.Count == 0)
            {
                MessageBox.Show("Nema planova");
                //this.Close();
                return;
            }
            int index = pretraziPlan.PlanoviDGV.CurrentCell.RowIndex;
            Plan selektovanPlan = pretraziPlan.planovi[index];

            //FormDetaljiPlana formDetaljiPlana = new FormDetaljiPlana(selektovanPlan);
            //formDetaljiPlana.ShowDialog();
            MainCoordinator.Instance.PrikaziDetaljiPlanaPanel(selektovanPlan);

            //pretraziPlan.planovi = new BindingList<Plan>(Communication.Instance.UcitajListuPlanova());
            //pretraziPlan.PlanoviDGV.DataSource = null;
            //pretraziPlan.PlanoviDGV.DataSource = pretraziPlan.planovi;

        }

        private void PretraziButton1(object sender, EventArgs e)
        {
            pretraziPlan.planovi = new BindingList<Plan>(Communication.Instance.PretraziPlanove(pretraziPlan.PretragaTextBox1.Text));
            if (pretraziPlan.planovi.Count == 0)
                MessageBox.Show("Sistem ne moze da nadje planove po zadatoj vrednosti.");
            else
            {
                pretraziPlan.PlanoviDGV.DataSource = null;
                pretraziPlan.PlanoviDGV.DataSource = pretraziPlan.planovi;
            }
        }

    }
}

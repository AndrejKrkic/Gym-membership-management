using Common;
using Common.Domain;
using Klijent.GuiController;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klijent
{
    public partial class GlavnaEkranskaForma : Form
    {

        public GlavnaEkranskaForma(string korisnik)
        {
            InitializeComponent();
            PorukaUlogovanoglabel.Text += korisnik;
            MainCoordinator.Instance.DajReferencu(this);
        }

        public void ChangePanel(Control control)
        {
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(control);
            //control.Dock = DockStyle.Fill;
            //MainPanel.AutoSize = true;
            //MainPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        }


        private void kreirajClanaButton_Click(object sender, EventArgs e)
        {
            MainCoordinator.Instance.PrikaziKreirajClanaPanel();
        }

        private void PretraziClanaButton_Click(object sender, EventArgs e)
        {
            MainCoordinator.Instance.PrikaziPretraziClanaPanel();
        }

        private void KreirajTreneraButton_Click(object sender, EventArgs e)
        {
            MainCoordinator.Instance.PrikaziKreirajTreneraPanel();
        }

        private void PretraziTreneraButton_Click(object sender, EventArgs e)
        {
            MainCoordinator.Instance.PrikaziPretraziTreneraPanel();
        }

        private void PlanKreirajButton1_Click(object sender, EventArgs e)
        {
            MainCoordinator.Instance.PrikaziKreirajPlanPanel();
        }

        private void IzmeniPlanButton1_Click(object sender, EventArgs e)
        {
            MainCoordinator.Instance.PrikaziPretraziPlanPanel();
        }
    }
}

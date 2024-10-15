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
    public class PretraziTreneraGuiController
    {
        private UCPretraziTrenera pretraziTrenera; //INSTANCIRA FORMU
        internal Control NapraviPretraziTreneraFormu()
        {
            pretraziTrenera = new UCPretraziTrenera();
            pretraziTrenera.PretraziButton1.Click += PretraziButton1;
            pretraziTrenera.DetaljiButton2.Click += DetaljiButton;
            return pretraziTrenera;
        }

        private void PretraziButton1(object sender, EventArgs e)
        {
            pretraziTrenera.treneri = new BindingList<Trener>(Communication.Instance.PretraziTrenere(pretraziTrenera.PretraziTextBox1.Text));
            if (pretraziTrenera.treneri.Count == 0)
            {
                pretraziTrenera.treneri = new BindingList<Trener>(Communication.Instance.UcitajListuTrenera());
                MessageBox.Show("Sistem ne moze da nadje trenere po zadatoj vrednosti.");
            }
            else
            {
                pretraziTrenera.TreneriDGV.DataSource = null;
                pretraziTrenera.TreneriDGV.DataSource = pretraziTrenera.treneri;
            }
        }

        private void DetaljiButton(object sender, EventArgs e)
        {
            if (pretraziTrenera.treneri.Count == 0)
                return;
            int index = pretraziTrenera.TreneriDGV.CurrentCell.RowIndex;
            //Console.WriteLine(index);
            Trener selektovanTrener = pretraziTrenera.treneri[index];

            //FormDetaljiTrenera formDetaljiTrenera = new FormDetaljiTrenera(selektovanTrener);
            //formDetaljiTrenera.ShowDialog();
            MainCoordinator.Instance.PrikaziDetaljiTreneraPanel(selektovanTrener);

            //pretraziTrenera.treneri = new BindingList<Trener>(Communication.Instance.PretraziTrenere(pretraziTrenera.PretraziTextBox1.Text));
            //pretraziTrenera.TreneriDGV.DataSource = null;
            //pretraziTrenera.TreneriDGV.DataSource = pretraziTrenera.treneri;

        }
    }
}

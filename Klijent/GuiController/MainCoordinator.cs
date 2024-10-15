using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klijent.GuiController
{
    public class MainCoordinator
    {
        private static MainCoordinator instance; //singleton pattern
        public static MainCoordinator Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new MainCoordinator();
                }
                return instance;
            }
        }

        private GlavnaEkranskaForma glavnaEkranskaForma;
        public void DajReferencu(GlavnaEkranskaForma glavnaEkranskaForma)
        {
            this.glavnaEkranskaForma = glavnaEkranskaForma;
        }




        //instance kontroleraa
        private KreirajClanaGuiController kreirajClanaGuiController;
        private KreirajTreneraController kreirajTreneraController;
        private KreirajPlanTreningaGuiController KreirajPlanTreningaGuiController;
        PretraziClanaGuiController pretraziClanaGuiController;
        PretraziTreneraGuiController pretraziTreneraGuiController;
        PretraziPlanTreningaGuiController pretraziPlanTreningaGuiController;
        DetaljiClanaGuiController detaljiClanaGuiController;
        DetaljiTreneraGuiController detaljiTreneraGuiController;
        DetaljiPlanaTreningaGuiController detaljiPlanaTreningaGuiController;

        private MainCoordinator()
        {
            kreirajClanaGuiController = new KreirajClanaGuiController();//instancira person Controller
            kreirajTreneraController = new KreirajTreneraController();
            KreirajPlanTreningaGuiController = new KreirajPlanTreningaGuiController();
            pretraziClanaGuiController = new PretraziClanaGuiController();
            pretraziTreneraGuiController = new PretraziTreneraGuiController();
            pretraziPlanTreningaGuiController = new PretraziPlanTreningaGuiController();
            detaljiClanaGuiController = new DetaljiClanaGuiController();
            detaljiTreneraGuiController = new DetaljiTreneraGuiController();
            detaljiPlanaTreningaGuiController = new DetaljiPlanaTreningaGuiController();
        }

        


        internal void PrikaziKreirajClanaPanel()
        {
            glavnaEkranskaForma.ChangePanel(kreirajClanaGuiController.NapraviDodajClanaFormu());
        }

        internal void PrikaziKreirajTreneraPanel()
        {
            glavnaEkranskaForma.ChangePanel(kreirajTreneraController.NapraviDodajTreneraFormu());
        }

        internal void PrikaziKreirajPlanPanel()
        {
            glavnaEkranskaForma.ChangePanel(KreirajPlanTreningaGuiController.NapraviKreirajPlanFormu());
        }

        internal void PrikaziPretraziClanaPanel()
        {
            glavnaEkranskaForma.ChangePanel(pretraziClanaGuiController.NapraviPretraziClanaFormu());
        }

        internal void PrikaziPretraziTreneraPanel()
        {
            glavnaEkranskaForma.ChangePanel(pretraziTreneraGuiController.NapraviPretraziTreneraFormu());
        }
        internal void PrikaziPretraziPlanPanel()
        {
            glavnaEkranskaForma.ChangePanel(pretraziPlanTreningaGuiController.NapraviPretraziPlanFormu());
        }
        internal void PrikaziDetaljiClanaPanel(Clan clan)
        {
            glavnaEkranskaForma.ChangePanel(detaljiClanaGuiController.NapraviDetaljiClanaFormu(clan));
        }
        internal void PrikaziDetaljiTreneraPanel(Trener trener)
        {
            glavnaEkranskaForma.ChangePanel(detaljiTreneraGuiController.NapraviDetaljiTreneraFormu(trener));
        }
        internal void PrikaziDetaljiPlanaPanel(Plan plan)
        {
            glavnaEkranskaForma.ChangePanel(detaljiPlanaTreningaGuiController.NapraviDetaljiPlanFormu(plan));
        }
    }
}

using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Seminarski_Andrej_Krkic_2020_0206.SystemOperation;
using Common.Domain;
using DBBroker;

namespace Seminarski_Andrej_Krkic_2020_0206
{
    public class Controller
    {
        private static Controller _instance;
        public static Controller Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Controller();

                    return _instance;
            }
        }

        public Korisnik Login(Korisnik korisnik)
        {
            LoginSO login = new LoginSO(korisnik);
            login.ExecuteTemplate();
            return login.Result;
        }

        public void KreirajClana(Clan clan)
        {
            KreirajClanaSO kreirajClanaSO = new KreirajClanaSO(clan);
            kreirajClanaSO.ExecuteTemplate();
        }

        public List<Mesto> UcitajListuMesta()
        {
            UcitajListuMestaSO ucitajListuMestaSO = new UcitajListuMestaSO();
            ucitajListuMestaSO.ExecuteTemplate();
            return ucitajListuMestaSO.Result;

        }

        public List<Clan> UcitajListuClanova()
        {
            UcitajListuClanovaSO ucitajListuClanovaSO = new UcitajListuClanovaSO();
            ucitajListuClanovaSO.ExecuteTemplate();
            return ucitajListuClanovaSO.Result;
        }

        internal List<Clan> PretraziClanove(string pretraga)
        {
            PretraziClanoveSO pretraziClanoveSO = new PretraziClanoveSO(pretraga);
            pretraziClanoveSO.ExecuteTemplate();
            return pretraziClanoveSO.Result;
        }

        internal void IzmeniClana(Clan clan)
        {
            IzmeniClanaSO izmeniClanaSO = new IzmeniClanaSO(clan);
            izmeniClanaSO.ExecuteTemplate();
        }

        internal void ObrisiClana(Clan clan)
        {
            ObrisiClanaSO obrisiClanaSO = new ObrisiClanaSO(clan);
            obrisiClanaSO.ExecuteTemplate();
        }

        internal void KreirajTrenera(Trener trener)
        {
            KreirajTreneraSO kreirajTreneraSO = new KreirajTreneraSO(trener);
            kreirajTreneraSO.ExecuteTemplate();

        }

        internal List<Trener> UcitajListuTrenera()
        {
            UcitajListuTreneraSO ucitajListuTreneraSO = new UcitajListuTreneraSO();
            ucitajListuTreneraSO.ExecuteTemplate();
            return ucitajListuTreneraSO.Result;
        }

        internal List<Trener> PretraziTrenere(string pretraga)
        {
            PretrazivanjeTreneraSO pretrazivanjeTreneraSO = new PretrazivanjeTreneraSO(pretraga);
            pretrazivanjeTreneraSO.ExecuteTemplate();
            return pretrazivanjeTreneraSO.Result;
        }

        internal void IzmeniTrenera(Trener trener)
        {
            IzmeniTreneraSO izmeniTreneraSO = new IzmeniTreneraSO(trener);
            izmeniTreneraSO.ExecuteTemplate();
        }

        internal void ObrisiTrenera(Trener trener)
        {
            ObrisiTreneraSO obrisiTreneraSO = new ObrisiTreneraSO(trener);
            obrisiTreneraSO.ExecuteTemplate();
        }

        internal List<Vezba> UcitajListuVezbi()
        {
            UcitajListuVezbiSO ucitajListuVezbiSO = new UcitajListuVezbiSO();
            ucitajListuVezbiSO.ExecuteTemplate();
            return ucitajListuVezbiSO.Result;
        }

        internal void KreirajPlan((Plan, List<StavkaPlana>) argument)
        {
            KreirajPlanSO kreirajPlanSO = new KreirajPlanSO(argument.Item1, argument.Item2);
            kreirajPlanSO.ExecuteTemplate();
        }

        internal List<Plan> UcitajListuPlanova()
        {
            UcitajListuPlanovaSO ucitajListuPlanovaSO = new UcitajListuPlanovaSO();
            ucitajListuPlanovaSO.ExecuteTemplate();
            return ucitajListuPlanovaSO.Result;
        }

        internal List<StavkaPlana> UcitajListuStavkiPlanova((int, int) argument)
        {
            UcitajListuStavkiPlanovaSO ucitajListuStavkiPlanovaSO = new UcitajListuStavkiPlanovaSO(argument);
            ucitajListuStavkiPlanovaSO.ExecuteTemplate();
            return ucitajListuStavkiPlanovaSO.Result;
        }

        internal void IzmeniPlan((Plan, List<StavkaPlana>, List<StavkaPlana>) argument)
        {
            IzmeniPlanSO izmeniPlanSO = new IzmeniPlanSO(argument.Item1, argument.Item2, argument.Item3);
            izmeniPlanSO.ExecuteTemplate();
        }

        internal object PretraziPlanove(string argument)
        {
            PretraziPlanoveSO pretraziPlanoveSO = new PretraziPlanoveSO(argument);
            pretraziPlanoveSO.ExecuteTemplate();
            return pretraziPlanoveSO.Result;
        }
    }
}

using Common.Domain;
using DBBroker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminarski_Andrej_Krkic_2020_0206.SystemOperation
{
    public class PretraziPlanoveSO : SystemOperationBase
    {
        public List<Plan> Result { get; set; }
        string pretraga;
        public PretraziPlanoveSO(string pretraga)
        {
            this.pretraga = pretraga;
        }

        protected override void ExecuteConcreteOperation()
        {
            Plan plan = new Plan();
            plan.SearchValues = $"p.*, t.ime as 'ImeTrenera',  c.Ime as 'ImeClana' FROM [PLAN] p JOIN Trener t ON (p.TrenerID = t.TrenerID) JOIN Clan c ON (p.ClanID = c.ClanID) WHERE Naziv LIKE '{pretraga}%'";
            List<IEntity> entiteti = broker.Pretrazi(plan);
            List<Plan> planovi = new List<Plan>();
            foreach (IEntity item in entiteti)
            {
                planovi.Add((Plan)item);
            }
            Result = planovi;

            //SELECT p.*, t.ime as 'ImeTrenera',  c.Ime as 'ImeClana' FROM [PLAN] p JOIN Trener t ON (p.TrenerID = t.TrenerID) JOIN Clan c ON (p.ClanID = c.ClanID) WHERE Naziv LIKE 'p%'
        }

    }
}

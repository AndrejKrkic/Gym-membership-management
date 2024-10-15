using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminarski_Andrej_Krkic_2020_0206.SystemOperation
{
    internal class IzmeniPlanSO : SystemOperationBase
    {
        Plan plan;
        List<StavkaPlana> stavkePlana;
        List<StavkaPlana> stavkePlanaZaBrisanje;
        public IzmeniPlanSO(Plan plan, List<StavkaPlana> stavkePlana, List<StavkaPlana> stavkePlanaZaBrisanje)
        {
            this.plan = plan;
            this.stavkePlana = stavkePlana;
            this.stavkePlanaZaBrisanje = stavkePlanaZaBrisanje;
        }

        protected override void ExecuteConcreteOperation()
        {
          

            broker.Izmeni(plan);
            foreach (StavkaPlana stavka in stavkePlana)
            {
               
                if (stavka.Status == Status.Added)
                {
                    broker.Kreiraj(stavka);
                }
            }

            foreach (StavkaPlana stavka in stavkePlanaZaBrisanje)
            {
                broker.Obrisi(stavka);
            }
        }
    }
}

using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminarski_Andrej_Krkic_2020_0206.SystemOperation
{
    public class KreirajPlanSO : SystemOperationBase
    {
        Plan plan;
        List<StavkaPlana> stavkePlana;
        public KreirajPlanSO(Plan plan, List<StavkaPlana> stavkePlana)
        {
            this.plan = plan;
            this.stavkePlana = stavkePlana;    
        }

        protected override void ExecuteConcreteOperation()
        {
            broker.Kreiraj(plan);
            
            foreach (StavkaPlana stavka in stavkePlana)
            {
                broker.Kreiraj(stavka);
            }
        }
    }
}

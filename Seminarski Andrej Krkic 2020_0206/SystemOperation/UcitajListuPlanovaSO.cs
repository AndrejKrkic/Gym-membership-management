using Common.Domain;
using DBBroker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminarski_Andrej_Krkic_2020_0206.SystemOperation
{
    public class UcitajListuPlanovaSO : SystemOperationBase
    {
        public List<Plan> Result { get; set; }
        public UcitajListuPlanovaSO()
        {

        }
        protected override void ExecuteConcreteOperation()
        {
            List<IEntity> entiteti = broker.UcitajSveSaUslovom(new Plan());
            List<Plan> planovi = new List<Plan>();
            foreach (Plan item in entiteti)
            {
                planovi.Add(item);
            }
            Result = planovi;
        }
    }
}

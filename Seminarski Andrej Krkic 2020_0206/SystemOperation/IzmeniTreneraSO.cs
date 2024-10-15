using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminarski_Andrej_Krkic_2020_0206.SystemOperation
{
    internal class IzmeniTreneraSO : SystemOperationBase
    {
        Trener trener;
        public IzmeniTreneraSO(Trener trener)
        {
            this.trener = trener;
        }

        protected override void ExecuteConcreteOperation()
        {
            broker.Izmeni(trener);
        }
    }
}

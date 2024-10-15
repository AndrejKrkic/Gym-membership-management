using Common.Domain;
using DBBroker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminarski_Andrej_Krkic_2020_0206.SystemOperation
{
    public class UcitajListuTreneraSO : SystemOperationBase
    {
        public List<Trener> Result { get; set; }
        public UcitajListuTreneraSO()
        {

        }
        protected override void ExecuteConcreteOperation()
        {
            List<IEntity> entiteti = broker.GetAll(new Trener());
            List<Trener> treneri = new List<Trener>();
            foreach (Trener item in entiteti)
            {
                treneri.Add(item);
            }
            Result = treneri;
        }
    }
}

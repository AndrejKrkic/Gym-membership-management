using Common.Domain;
using DBBroker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminarski_Andrej_Krkic_2020_0206.SystemOperation
{
    public class UcitajListuVezbiSO : SystemOperationBase
    {
        public List<Vezba> Result { get; set; }
        public UcitajListuVezbiSO()
        {

        }
        protected override void ExecuteConcreteOperation()
        {
            List<IEntity> entiteti = broker.GetAll(new Vezba());
            List<Vezba> vezbe = new List<Vezba>();
            foreach (Vezba vezba in entiteti)
            {
                vezbe.Add(vezba);
            }
            Result = vezbe;
        }
    }
}

using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminarski_Andrej_Krkic_2020_0206.SystemOperation
{
    public class UcitajListuMestaSO : SystemOperationBase
    {
        public List<Mesto> Result { get; set; }
        public UcitajListuMestaSO()
        {
                
        }

        protected override void ExecuteConcreteOperation()
        {
            List<IEntity> entiteti = broker.GetAll(new Mesto());
            List<Mesto> mesta = new List<Mesto>();
            foreach (Mesto mesto in entiteti)
            {
                mesta.Add(mesto);
            }
            Result = mesta;
        }
    }
}

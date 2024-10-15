using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminarski_Andrej_Krkic_2020_0206.SystemOperation
{
    internal class PretrazivanjeTreneraSO : SystemOperationBase
    {
        public List<Trener> Result { get; set; }
        string pretraga;
        public PretrazivanjeTreneraSO(string pretraga)
        {
            this.pretraga = pretraga;
        }

        protected override void ExecuteConcreteOperation()
        {
            Trener trener = new Trener();
            trener.SearchValues = $"* FROM Trener WHERE Ime LIKE '{pretraga}%'";
            List<IEntity> entiteti = broker.Pretrazi(trener);
            List<Trener> treneri = new List<Trener>();
            foreach (IEntity item in entiteti)
            {
                treneri.Add((Trener)item);
            }
            Result = treneri;
            //WHERE Ime LIKE '{pretraga}%'
        }
    }
}

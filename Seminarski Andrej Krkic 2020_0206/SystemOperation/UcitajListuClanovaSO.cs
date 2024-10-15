using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminarski_Andrej_Krkic_2020_0206.SystemOperation
{
    public class UcitajListuClanovaSO : SystemOperationBase
    {
        public List<Clan> Result { get; set; }
        public UcitajListuClanovaSO()
        {
                
        }
        protected override void ExecuteConcreteOperation()
        {
            IEntity entity = new Clan();
            List<IEntity> entiteti = broker.UcitajSveSaUslovom(entity);
            List<Clan> clanovi = new List<Clan>();
            foreach (IEntity item in entiteti)
            {
                clanovi.Add((Clan)item);
            }
            Result = clanovi;
        }
    }
}

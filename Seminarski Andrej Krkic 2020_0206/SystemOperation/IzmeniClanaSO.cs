using Common.Domain;
using DBBroker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminarski_Andrej_Krkic_2020_0206.SystemOperation
{
    public class IzmeniClanaSO : SystemOperationBase
    {
        IEntity clan;
        public IzmeniClanaSO(Clan clan)
        {
            this.clan = clan;
            
        }

        protected override void ExecuteConcreteOperation()
        {
            broker.Izmeni(clan);
        }
    }
}

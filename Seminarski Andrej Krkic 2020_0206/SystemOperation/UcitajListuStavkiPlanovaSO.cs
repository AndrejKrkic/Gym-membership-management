using Common.Domain;
using DBBroker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminarski_Andrej_Krkic_2020_0206.SystemOperation
{
    public class UcitajListuStavkiPlanovaSO : SystemOperationBase
    {
        public List<StavkaPlana> Result { get; set; }
        int trenerID, clanID;
        public UcitajListuStavkiPlanovaSO((int, int) argument)
        {
            trenerID = argument.Item1;
            clanID = argument.Item2;
        }
        protected override void ExecuteConcreteOperation()
        {
            StavkaPlana stavkaPlana = new StavkaPlana();
            stavkaPlana.Trener = new Trener();
            stavkaPlana.Clan = new Clan();
            stavkaPlana.Trener.TrenerID = trenerID;
            stavkaPlana.Clan.ClanId = clanID;
            List<IEntity> entiteti = broker.UcitajSveSaUslovom(stavkaPlana);
            List<StavkaPlana> stavkePlanova = new List<StavkaPlana>();
            foreach (StavkaPlana item in entiteti)
            {
                stavkePlanova.Add(item);
            }
            Result = stavkePlanova;
        }
    }
}

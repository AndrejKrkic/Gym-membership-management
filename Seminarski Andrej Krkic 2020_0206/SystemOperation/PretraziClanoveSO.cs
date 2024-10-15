using Common.Domain;
using DBBroker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminarski_Andrej_Krkic_2020_0206.SystemOperation
{
    public class PretraziClanoveSO : SystemOperationBase
    {

        public List<Clan> Result { get; set; }
        string pretraga;
        public PretraziClanoveSO(string pretraga)
        {
            this.pretraga = pretraga;
        }

        protected override void ExecuteConcreteOperation()
        {
            Clan clan = new Clan();
            clan.SearchValues = $"* FROM Clan c JOIN Mesto m ON(c.Mesto = m.MestoID) WHERE Ime LIKE '{pretraga}%'";
            List<IEntity> entiteti = broker.Pretrazi(clan);
            List<Clan> clanovi = new List<Clan>();
            foreach (IEntity item in entiteti)
            {
                clanovi.Add((Clan)item);
            }
            Result = clanovi;

            //c JOIN Mesto m ON(c.Mesto = m.MestoID) WHERE Ime LIKE '{pretraga}%'
        }
    }
}

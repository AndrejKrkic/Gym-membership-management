using Common;
using Common.Domain;
using DBBroker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminarski_Andrej_Krkic_2020_0206.SystemOperation
{
    public class LoginSO : SystemOperationBase
    {
        Korisnik korisnik;
        public Korisnik Result { get; set; } //posto je apstraktna metoda ne moze da ima drugaciji potpis

        public LoginSO(Korisnik korisnik)
        {
            this.korisnik = korisnik;
            
        }

        protected override void ExecuteConcreteOperation()
        {
            //Result = broker.Login(korisnik);

            List<IEntity> entiteti = broker.Login(korisnik);

            if(entiteti != null)
            {
                Result = (Korisnik)entiteti[0];
            }
            else
            {
                Result = null;
            }

        }
    }
}

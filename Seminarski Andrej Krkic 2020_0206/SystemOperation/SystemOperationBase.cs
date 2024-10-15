using DBBroker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminarski_Andrej_Krkic_2020_0206.SystemOperation
{
    public abstract class SystemOperationBase
    {
        //template method pattern sluzi samo da ne ponavljamo kod, a stalno moramo da otvaramo i zatvaramo konekciju
        protected Broker broker;

        public SystemOperationBase()
        {
            broker = new Broker();
        }


        public void ExecuteTemplate()
        {
            try
            {
                broker.OpenConnection();
                broker.BeginTransaction();

                ExecuteConcreteOperation();

                broker.Commit();
            }
            catch (Exception ex)
            {
                broker.Rollback();
                throw ex;
            }
            finally
            {
                broker.CloseConnection();
            }
        }

        protected abstract void ExecuteConcreteOperation();

    }
}

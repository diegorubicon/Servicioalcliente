using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccessDataLib;

namespace SFC.Infrastructure
{
    public class Transaction 
    {
        IConnectionFactory connectionfactory;
        public Transaction(IConnectionFactory connectionfactory)
        {
            this.connectionfactory = connectionfactory;
        }

        public void BeginTransaction()
        {
            connectionfactory.CreateTransaction();
        }

        public void Commit()
        {
            connectionfactory.CommitTransaction();
        }

        public void RollBackTransaction()
        {
            connectionfactory.RollbackTransaction();
        }
    }
}

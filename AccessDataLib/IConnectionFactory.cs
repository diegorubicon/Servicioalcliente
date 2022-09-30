using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessDataLib
{
    public interface IConnectionFactory
    {
        DbConnection CreateConnection();
        void CreateTransaction();
        void CommitTransaction();
        void RollbackTransaction();
        DbTransaction getActiveTransaction();       
        
    }
}

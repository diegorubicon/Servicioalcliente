using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.Common;

namespace AccessDataLib
{
    public class ConnectionFactory : IConnectionFactory
    {
        private DbConnection db = null;
        private DbTransaction transac = null;

        //Eventos
        public delegate void OnErrorEventHandler(Exception exception);
        public event OnErrorEventHandler OnConnectionFailed;

        public ConnectionFactory(string connectionstringname)
        {
            ConnectionStringSettings connectionSettings = ConnectionStringBroker.GetConnectionSettings(connectionstringname);

            db = DbProviderFactories.GetFactory(connectionSettings.ProviderName).CreateConnection();
            db.ConnectionString = connectionSettings.ConnectionString;
        }
        public DbConnection CreateConnection()
        {
            if (db.State != System.Data.ConnectionState.Open)
            {
                try
                {
                    
                    db.Open();   //intenta abrir la conexion con la base de datos
                }
                catch (Exception ex)
                {
                    //no se pudo abrir la conexion con la base de datos
                    //dispara el evento
                    if (!(OnConnectionFailed == null))
                        OnConnectionFailed(ex);
                    return null;
                }
            }
            return db;
        }

        public void CreateTransaction()
        {
            transac = db.BeginTransaction();
        }
        public DbTransaction getActiveTransaction() => transac;
        public void CommitTransaction()
        {
            transac.Commit();
        }
        public void RollbackTransaction()
        {
            transac.Rollback();
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace Vendedores.DataAccess
{
    public class DataIO :IDisposable
    {
        private SqlConnection db = null;

        private Boolean disposed = false;
        public DataIO(string ConnectionString)
        {
            try
            {
                db = new SqlConnection(ConnectionString);
                db.Open();
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo abrir la conexion al origen de datos " + ex.Message);
            }
        }
        public SqlDataReader RetrieveReader(string Query)
        {
            if (db.State == System.Data.ConnectionState.Open)
            {
                SqlCommand cmd = new SqlCommand(Query, db);
                cmd.CommandType = System.Data.CommandType.Text;
                
                SqlDataReader reader = cmd.ExecuteReader();
               

                return reader;
            }
            else
            {
                return null;
            }

        }  
         /// <summary>
        /// Implementación de IDisposable. No se sobreescribe.
        /// </summary>
        public void Dispose()
        {
            this.Dispose(true);
            // GC.SupressFinalize quita de la cola de finalización al objeto.
            GC.SuppressFinalize(this);
        }
         protected virtual void Dispose(bool disposing) {
        // Preguntamos si Dispose ya fue llamado.
        if (!this.disposed) {
            if (disposing) {
                // Llamamos al Dispose de todos los RECURSOS MANEJADOS.
                this.db.Dispose();
            }
 
            // Acá finalizamos correctamente los RECURSOS NO MANEJADOS
            // ...
 
        }
        this.disposed = true;
    }
 
    /// <summary>
    /// Destructor de la instancia
    /// </summary>
     ~DataIO() 
     {
        this.Dispose(false);
        }
 

    }
}

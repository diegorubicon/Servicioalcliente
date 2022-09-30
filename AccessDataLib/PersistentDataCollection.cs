using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Dynamic;
using System.Linq.Expressions;
using System.Collections;
using System.Reflection;

namespace AccessDataLib
{
    public class PersistentDataCollection<T> 
    {       
        private IConnectionFactory connectionfactory;
        public PersistentDataCollection(IConnectionFactory connectionfactory)
        {
            this.connectionfactory = connectionfactory;
        }
        /// <summary>
        /// Retorna un elemento de la capa persistente
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        public T getRow(object filter)
        {           
            var connection = connectionfactory.CreateConnection();
            if (connection != null)
            {
                return connection.Get<T>(filter, connectionfactory.getActiveTransaction());
            }
            else
                return default(T);
        }
        public IEnumerable<T> getRows(object filter)
        {                     
            var connection = connectionfactory.CreateConnection();
            if (connection != null)
            {
                return connection.GetList<T>(filter, connectionfactory.getActiveTransaction());
            }
            else
                return null;
        }        

        public IEnumerable<T> getRows(Expression<Func<T, bool>> expresion)
        {
            var connection = connectionfactory.CreateConnection();
            if (connection != null)
            {
                return connection.GetList<T>(expresion, connectionfactory.getActiveTransaction());
            }
            else
                return null;
        }
        public void Insert(T NewElement)
        {
            var connection = connectionfactory.CreateConnection();
            if (connection != null)
            {
                connection.Insert(NewElement, connectionfactory.getActiveTransaction());
            }
            else
                throw new Exception("No se pudo insertar el elemento no hay una conexion activa con la base de datos");
        }
        public TKey Insert<TKey>(T NewElement)
        {
            var connection = connectionfactory.CreateConnection();
            if (connection != null)
            {
                return connection.Insert<TKey, T>(NewElement, connectionfactory.getActiveTransaction());
            }
            else
                return default(TKey);
        }
        public void Update(T element)
        {
            var connection = connectionfactory.CreateConnection();
            if (connection != null)
            {
                connection.Update(element, connectionfactory.getActiveTransaction());
            }
        }
        public void Update(T oldelement, T newelement)
        {
            var connection = connectionfactory.CreateConnection();
            if (connection != null)
            {
                connection.Update(oldelement, newelement, connectionfactory.getActiveTransaction());
            }
        }
        public void Update(T element, object fields)
        {
            var connection = connectionfactory.CreateConnection();
            if (connection != null)
            {
                connection.Update(element, fields, connectionfactory.getActiveTransaction());
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq;

namespace Academic.DataAccess
{
    public class Generic2<Entity> : IDisposable where Entity : class
    {
        private bool _disposed;
        protected DataContext db = null;

        public Generic2(string ConnectionString)
        {            
            db = new DataContext(ConnectionString);
        }

        private IEnumerable<Entity> Select()
        {
            return db.GetTable<Entity>();
        }
        public IEnumerable<Entity> Select(Func<Entity, bool> predicate)
        {
            return db.GetTable<Entity>().Where(predicate);
        }
        public List<Entity> LoadAll()
        {
            try
            {
                return Select().ToList();
            }
            catch (Exception)
            {
                return new List<Entity>();
            }
        }
        public void Insert (Entity entity) 
        {      
           try
            {
                db.GetTable<Entity>().InsertOnSubmit(entity);                
                db.SubmitChanges();
            }
            catch (Exception)
            {
                throw;
            }           
        }
        public void Update(Entity entity)
        {
        }
        public bool Exist(Func<Entity, bool> predicate)
        {
            try
            {
                if (Select().Where(predicate).Count() == 0)
                    return false;
                else
                    return true;
            }
            catch (Exception)
            {
                return true;
            }
        }
        #region "Destructor"
        public void Dispose()
        {
            Dispose(true);
        }
        protected virtual void Dispose(bool disposing)
        {
            // If you need thread safety, use a lock around these  
            // operations, as well as in your methods that use the resource. 
            if (!_disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
                db = null;
                _disposed = true;
            }
        }
        #endregion
    }
}

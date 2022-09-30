using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data.Linq;
using System.ComponentModel;  

namespace Facturacion.DataAccess
{
    public abstract class GenericDAO<EntityLinq, Entity> : IDisposable where EntityLinq : class
    {
        private bool _disposed;
        protected DataMapDataContext db;
        protected string _cnnstr;

        public GenericDAO(String ConnectionString)
        {
            _cnnstr = ConnectionString;

            db = new DataMapDataContext(_cnnstr);
        }
        protected abstract EntityLinq CastToLinq(Entity p);

       

        protected abstract IEnumerable<Entity> SelectToEntity();

        public virtual void GenericInsert(EntityLinq entity)
        {
            ITable tab = db.GetTable(entity.GetType());
            tab.InsertOnSubmit(entity);
            try
            {
                db.SubmitChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public virtual void GenericUpdate(Func<EntityLinq, bool> UpdateCriteria, EntityLinq newEntity)
        {
            if (Select().Where(UpdateCriteria).Count() == 0)
            {
                throw new Exception("No se encontro el registro para actualizar");
            }
            else
            {
                EntityLinq originalEntity = Select().Where(UpdateCriteria).First();

                //Obtiene todas las propiedades del registro a modificar
                PropertyDescriptorCollection originalProps = TypeDescriptor.GetProperties(originalEntity);

                foreach (PropertyDescriptor currentProp in originalProps)
                {
                    if (currentProp.Attributes[typeof(System.Data.Linq.Mapping.ColumnAttribute)] != null)
                    {
                        object val = currentProp.GetValue(newEntity);  //Obtiene el valor de la propiedad actual en el componente newEntity

                        currentProp.SetValue(originalEntity, val); //Establece el valor de la propiedad actual en componente OriginalEntity
                    }
                }
                try
                {
                    db.SubmitChanges();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
        public virtual void GenericDelete(Func<EntityLinq, bool> DeleteCriteria)
        {

            EntityLinq ul = Select().Where(DeleteCriteria).First();

            ITable tab = db.GetTable(ul.GetType());
            tab.DeleteOnSubmit(ul);
            try
            {
                db.SubmitChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }


        public List<Entity> LoadAll()
        {
            return SelectToEntity().ToList();
        }
        public List<Entity> Filter(Func<Entity, bool> criterio)
        {
            return SelectToEntity().Where(criterio).ToList();
        }

        private IEnumerable<EntityLinq> Select()
        {
            return db.GetTable<EntityLinq>();
        }

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

    }
}

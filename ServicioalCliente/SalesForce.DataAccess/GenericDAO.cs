using System;
using System.Collections;
using System.Collections.Specialized;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Text;
using System.ComponentModel;
using System.Configuration;
using System.Reflection;

namespace SalesForce.DataAccess
{
    public abstract class GenericDAO<EntityLinq, Entity> : IDisposable where EntityLinq : class
    {
        private bool _disposed;
        protected DataMapDataContext db;
        protected string _cnnstr;

        public GenericDAO(string ConnectionString)
        {
            _cnnstr = ConnectionString;
            db = new DataMapDataContext(_cnnstr);
        }
        public GenericDAO()
        {
            _cnnstr = ConfigurationManager.ConnectionStrings["default"].ToString();

            db = new DataMapDataContext(_cnnstr);
        }
        #region "Metodos a implementar"
        protected abstract EntityLinq CastToLinq(Entity p);
        protected abstract Entity CastToEntity(EntityLinq p);

        protected abstract IEnumerable<Entity> SelectToEntity();
        #endregion
        #region "CRUD"
        public virtual void Insert(Entity entity)
        {
            EntityLinq LinqObj = CastToLinq(entity);

            ITable tab = db.GetTable(LinqObj.GetType());
            tab.InsertOnSubmit(LinqObj);

            try
            {
                db.SubmitChanges();
            }
            catch (Exception)
            {
                throw;
            }
            Entity newEntity = CastToEntity(LinqObj);

            PropertyDescriptorCollection originalProps = TypeDescriptor.GetProperties(entity);

            foreach (PropertyDescriptor currentProp in originalProps)
            {
                object val = currentProp.GetValue(newEntity);  //Obtiene el valor de la propiedad actual en el componente newEntity
                if (val != null)
                {
                        currentProp.SetValue(entity, val); //Establece el valor de la propiedad actual en componente OriginalEntity
                }               
            }           
        }
        public virtual void Update(Entity newEntity)
        {
            EntityLinq originalEntity = GetEntityLinq(newEntity);

            EntityLinq UpdateEntity = CastToLinq(newEntity);

            if (originalEntity == null)
                throw new Exception("No se encontro el registro para modificar");

            PropertyDescriptorCollection originalProps = TypeDescriptor.GetProperties(originalEntity);

            foreach (PropertyDescriptor currentProp in originalProps)
            {
                if (currentProp.Attributes[typeof(System.Data.Linq.Mapping.ColumnAttribute)] != null)
                {
                    object val = currentProp.GetValue(UpdateEntity);  //Obtiene el valor de la propiedad actual en el componente newEntity
                    if (val != null)
                    {
                        currentProp.SetValue(originalEntity, val); //Establece el valor de la propiedad actual en componente OriginalEntity
                    }
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
        public virtual void Delete(Entity DelEntity)
        {

            EntityLinq ul = GetEntityLinq(DelEntity);
            if (ul == null)
            {
                throw new Exception("No se encontro el elemento a eliminar");
            }

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
        #endregion
        public bool Exist(Func<Entity, bool> predicate)
        {
            try
            {
                if (SelectToEntity().Where(predicate).Count() == 0)
                    return false;
                else
                    return true;
            }
            catch (Exception)
            {
                return true;
            }
        }
        public bool Fill(Entity ContainerDestiny, Func<Entity, bool> predicate)
        {
            try
            {
                Entity rst = SelectToEntity().Where(predicate).First();

                PropertyDescriptorCollection originalProps = TypeDescriptor.GetProperties(rst);

                foreach (PropertyDescriptor currentProp in originalProps)
                {
                    object val = currentProp.GetValue(rst);

                    currentProp.SetValue(ContainerDestiny, val);
                }

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool Fill(Entity ContainerDestiny)
        {
            try
            {
                Entity rst = SelectToEntity().First();

                PropertyDescriptorCollection originalProps = TypeDescriptor.GetProperties(rst);

                foreach (PropertyDescriptor currentProp in originalProps)
                {
                    object val = currentProp.GetValue(rst);

                    currentProp.SetValue(ContainerDestiny, val);
                }

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        #region "Seleccionar y filtrar"
        private EntityLinq GetEntityLinq(Entity e)
        {
            PropertyDescriptorCollection originalProps = TypeDescriptor.GetProperties(e);

            foreach (PropertyDescriptor currentProp in originalProps)
            {
                if (currentProp.Attributes[typeof(Generic.Entities.Atributo)] != null)
                {
                    return SelectByPK(currentProp.GetValue(e));
                }
            }
            return null;
        }
        private IEnumerable<EntityLinq> Select()
        {
            return db.GetTable<EntityLinq>();
        }
        private EntityLinq SelectByPK(object id)
        {
            try
            {

                var tab = db.GetTable<EntityLinq>();
                // get the metamodel mappings (database to domain objects)
                MetaModel modelMap = tab.Context.Mapping;
                // get the data members for this type
                ReadOnlyCollection<MetaDataMember> dataMembers = modelMap.GetMetaType(typeof(EntityLinq)).DataMembers;
                // find the primary key field name by checking for IsPrimaryKey
                string pk = (dataMembers.Single<MetaDataMember>(m => m.IsPrimaryKey)).Name;
                // return a single object where the id argument
                // matches the primary key field value

                return tab.SingleOrDefault<EntityLinq>(delegate(EntityLinq t)
                {
                    String memberId =
t.GetType().GetProperty(pk).GetValue(t,
null).ToString();
                    return memberId.ToString() ==
id.ToString();
                });
            }
            catch (Exception)
            {
                throw;
            }
        }
        public List<Entity> LoadAll()
        {
            try
            {
                return SelectToEntity().ToList();
            }
            catch (Exception)
            {
                return new List<Entity>();
            }
        }
        public List<Entity> Filter(Func<Entity, bool> criterio)
        {
            return SelectToEntity().Where(criterio).ToList();
        }
        #endregion
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
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;


namespace AccessDataLib
{
    public class Repository<TBusiness, T> 
        where TBusiness : new()
    {        
        private PersistentDataCollection<T> persistent;
        protected IConnectionFactory connectionfactory;
        protected IMapper Mapper;
        
        public Repository(IConnectionFactory connectionfactory)  
        {
            InitializeMappers();
            this.connectionfactory = connectionfactory;
            persistent = new PersistentDataCollection<T>(connectionfactory);            
        }        
        protected virtual void InitializeMappers()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<T, TBusiness>().ConstructUsing(x => new TBusiness());
                cfg.CreateMap<TBusiness, T>();
            });
            Mapper = config.CreateMapper();
        }
        protected virtual TBusiness Map(T dto)
        {
            return Mapper.Map<TBusiness>(dto);
        }
        protected virtual T Map(TBusiness businessobject)
        {
            return Mapper.Map<T>(businessobject);
        }
        /// <summary>
        /// Obtiene un elemento de la capa persistente
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        public TBusiness get(object filter)
        {     
            var rst = persistent.getRow(filter);
            if (rst == null)
                return default(TBusiness);
            else
                return Map(rst);
        }
        /// <summary>
        /// obtiene todos los elementos que cumplen con la condicion
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        public IEnumerable<TBusiness> getAll(object filter)
        {                      
            foreach (T dto in persistent.getRows(filter))
            {
                yield return Map(dto);
            }
        } 
        public IEnumerable<TBusiness> getAll()
        {
            return getAll(new { });
        }

        public IEnumerable<TBusiness>  getAll(Expression<Func<T, bool>> expresion)
        {
            foreach (T dto in persistent.getRows(expresion))
            {
                yield return Map(dto);
            }
        }
        /// <summary>
        /// Crea un nuevo elemento en la capa persistente
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        public virtual TBusiness Create(TBusiness element)
        {            
            persistent.Insert(Map(element));
            return element;
        } 
        public virtual TKey Create<TKey>(TBusiness element)
        {
            var rst = persistent.Insert<TKey>(Map(element));
            return rst;
        }
        public void Update(TBusiness element)
        {        
            persistent.Update(Map(element));
        }
        public void Update(TBusiness oldelement, TBusiness newelement)
        {         
            persistent.Update(Map(oldelement), Map(newelement));
        }
    }  
}

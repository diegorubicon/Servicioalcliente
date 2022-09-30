using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccessDataLib;

namespace SFC.Infrastructure
{
    public abstract class ChildRepository<TParent, TBusiness, T> : Repository<TBusiness, T>
        where TBusiness : new()
    {      
        public ChildRepository(IConnectionFactory connectionfactory) : base(connectionfactory)
        {
            this.connectionfactory = connectionfactory;
        }        
        public abstract T Map(TParent parent, TBusiness element);     
        public TBusiness Create(TParent parent, TBusiness element)
        {
            var persistent = new PersistentDataCollection<T>(connectionfactory);
            persistent.Insert(Map(parent, element));

            return element;
        }
    }
}

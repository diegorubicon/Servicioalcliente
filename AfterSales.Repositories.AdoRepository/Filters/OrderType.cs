using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AfterSales.Repositories.AdoRepositories.Filters
{
    public class OrderType : IFilter
    {
        public OrderType() : base("tipo") { }
        public OrderType(object value)
        : base("tipo")
        {
           
        }
    }
}

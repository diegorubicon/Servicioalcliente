using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AfterSales.Repositories.AdoRepositories.Filters
{
    public class OrderStatus : IFilter
    {
        public OrderStatus() : base("estado") { }
        public OrderStatus(object value)
        : base("estado")
        {
         
        }
    }
}

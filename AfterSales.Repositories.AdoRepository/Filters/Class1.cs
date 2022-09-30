using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AfterSales.Repositories.AdoRepositories.Filters
{
    public class AfterSaleStatus : IFilter
    {        
        public AfterSaleStatus() : base("postventa") { }
        public AfterSaleStatus(object value)
        : base("postventa")
        {
            
        }
    }
}

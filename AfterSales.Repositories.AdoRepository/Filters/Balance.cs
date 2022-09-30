using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AfterSales.Repositories.AdoRepositories.Filters
{
    public class Balance : IFilter
    {
        public Balance() : base("saldo_factura") { }
        public Balance(object value)
        : base("saldo_factura")
        {
            
        }
    }
}

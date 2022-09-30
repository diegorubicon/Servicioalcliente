using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellerLevel.DataAccess.Filters
{
    public class IdSalesManFilter : DataWarehouseLib.Filter
    {
        public IdSalesManFilter()
        {
        }
        public IdSalesManFilter(string Id)
            : base("v.vendedor")
        {
            this.Equal(Id);
        }
    }
}

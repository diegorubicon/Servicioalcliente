using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orders.Business
{
    public class Orders :List<factura>
    {
        protected Data.OrdersAD _ordersAD;
        public Orders() { }
        public Orders(String ConnectionString)
        {
            _ordersAD = new Data.OrdersAD(ConnectionString);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orders.Business
{
    public class OrdersBySalesMan:Orders
    {
        public OrdersBySalesMan(String ConnectionString,String _CodeSalesMan, int cierre)
        {
            try
            {

                _ordersAD = new Data.OrdersAD(ConnectionString);

                foreach (factura fact in _ordersAD.GetRowsSalesman(_CodeSalesMan, cierre))
                {
                    this.Add(fact);
                }
            }
            catch (Exception)
            {

            }
        }
    }
}

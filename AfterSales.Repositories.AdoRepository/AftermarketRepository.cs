using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AfterSales.Repositories.AdoRepositories
{
    public class AftermarketRepository<T>
        where T: new()
    {
        public IEnumerable<T> ToList()
        {
            /*Filters.OrderStatus Status = new Filters.OrderStatus();
            'Status.NotEqual(4);

            'Filters.OrderType Type = new Filters.OrderType();
            'Type.Minor(3);

            'Filters.Balance Balance = new Filters.Balance();
            'Balance.Minor(1);

            Filters.AfterSaleStatus aftersale = new Filters.AfterSaleStatus(0);

            DataTableBroker<T> Orders = new DataTableBroker<T>("facturas_encabezado");
            Orders.Where.Add(Status + Type + Balance + aftersale);
            foreach (T order in Orders.getAll())
            {
                yield return order;
            } */
            yield return default(T);
        }       

    }
}

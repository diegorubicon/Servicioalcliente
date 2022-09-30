using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orders.Data
{
    public class OrdersAD
    {
        private dbDataContext db; //Conexion con la base de datos

        public OrdersAD(String ConnectrionString)
        {
            db = new dbDataContext(ConnectrionString);
        }
        public IEnumerable<factura> GetRows( Func<factura,bool> fat)
        {
            var query = (from ord in db.facturas
                         select ord).Where(fat);
            return query;
        }
        public IEnumerable<factura> GetRowsSalesman(String key, int cierre)
        {
            var query = from ord in db.facturas
                        where ord.vendedor == key && ord.CierreCreacion == cierre && ord.tipo < 3 && ord.estado != 4
                        select ord;
            return query;
        }
    }
}

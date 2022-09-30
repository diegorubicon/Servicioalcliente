using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CirculosExcelencia.Data
{
   class Circulo
    {
        private DataBaseDataContext db = null;

        public Circulo(String ConnectionString)
        {
            db = new DataBaseDataContext(ConnectionString);
        }

        public CirculoExcelencia GetRowByVendedor(String Vendedor, Decimal CierreFinal)
        {
            var query = from circ in db.CirculoExcelencias
                        where circ.vendedor == Vendedor
                        && circ.cierre_final == CierreFinal
                        select circ;
            if (query.Count() > 0)
            {
                return query.First();
            }else{
                return null;
            }
        }
    }
}

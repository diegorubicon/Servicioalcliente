using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PuntosPremiate.Data
{
    class Premiate
    {
        private dbDataContext db = null;
        
        public Premiate (String ConnectionString)
        {
            db = new dbDataContext(ConnectionString);
        }

        public premiate GetRowByRango(Decimal id_premiate, decimal Monto)
        {
            var query = from premiate in db.premiates
                        where premiate.id == id_premiate
                        && Monto >= premiate.minimo
                        && Monto <= premiate.maximo
                        select premiate;
            if (query.Count() > 0)
            {
                return query.First();
            }
            else
            {
                return null;
            }
        }

    }
}

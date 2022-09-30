using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RegistrosDeVenta.Data
{
    class TempDS
    {
        private dbDataContext db = null;

        public TempDS (String ConnectionString)
        {
            db = new dbDataContext(ConnectionString);
        }
        public IEnumerable<RegistroTemp> GetRow(String vendedor)
        {
            var query = from row in db.RegistroTemps
                        where row.vendedor == vendedor
                        select row;
            return query;

        }
        public void Add(RegistroTemp rs)
        {
            db.RegistroTemps.InsertOnSubmit(rs);
        }

        public void UpdateDataSource()
        {
            try
            {
                db.SubmitChanges();
            }
            catch (Exception ex)
            {
            }
        }
     

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BonosExcelencia.Data
{
    class CierresAD
    {
        private DataBaseDataContext db = null;

        public CierresAD(String ConnectionString)
        {
            db = new DataBaseDataContext(ConnectionString);
        }
        public Cierre GetMaxCierre()
        {
            decimal? maximo;
            try
            {
                maximo = (from c in db.Cierres
                                   select c.id_cierre).Max();
            }
            catch
            {
                return null;
            }

             
            

            if (maximo.HasValue) 
            {
                var query = from c in db.Cierres
                            where c.id_cierre == maximo
                            select c;
            
                if (query.Count() > 0)
                {
                    return query.First();
                }
                else
                {
                    return null;
                }
            }else
            {
                return null;
            }
           
        }        

    }
}

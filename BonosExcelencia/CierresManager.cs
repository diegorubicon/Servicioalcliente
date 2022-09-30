using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BonosExcelencia
{
    public class CierresManager
    {
        private Data.CierresAD _DataSource = null;
        
        public CierresManager(String ConnectionString)
        {
            _DataSource = new Data.CierresAD(ConnectionString);
        }
        public Cierre CierreActual
        {
           get 
           {
               return _DataSource.GetMaxCierre();
           }
        }
    }
}

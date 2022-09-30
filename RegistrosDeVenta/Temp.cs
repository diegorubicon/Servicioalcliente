using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RegistrosDeVenta
{
    public class Temp : List<RegistroTemp>
    {
        private Data.TempDS _DataSource = null;

        public Temp( String ConnectionString, String Vendedor)
        {
            _DataSource = new Data.TempDS(ConnectionString);

            this.Clear();
            foreach (RegistroTemp rt in _DataSource.GetRow(Vendedor))
            {
                base.Add(rt);
            }
        }

        public new void Add(RegistroTemp rt)
        {
            _DataSource.Add(rt);
            try
            {
                _DataSource.UpdateDataSource();
            }
            catch (Exception ex)
            {
                
            }
            base.Add(rt);        

        }
        public void Update()
        {
            try
            {
                _DataSource.UpdateDataSource();
            }
            catch (Exception ex)
            {

            }
        }

    }
}

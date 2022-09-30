using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PuntosPremiate.Business
{
    public class Premiate:List<premiate>
    {
        private Data.Premiate _DataSource = null;

        public Premiate(String ConnectionString,Decimal Id_Premiate, Decimal Monto)
        {
            premiate pre = null;

            _DataSource = new Data.Premiate(ConnectionString);

            pre = _DataSource.GetRowByRango(Id_Premiate, Monto);

            if (pre != null)
            {
                this.Add(pre);
            }
        }
      }
}

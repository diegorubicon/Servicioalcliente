using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SalesMansLibrary.Business
{
    public class TeamSales:List<vendedor>
    {
        private Data.SalesMan _SalesManAD;

        public TeamSales(String ConnectionString, String Lider, int Periodo, bool WithLider)
        {
            _SalesManAD = new Data.SalesMan(ConnectionString);

            foreach (vendedor vend in _SalesManAD.GetVentasEquipo(Lider,Periodo,WithLider))
            {
                this.Add(vend);
            }
           
        }
    }
}

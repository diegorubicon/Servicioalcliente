using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SalesMansLibrary.Business
{
    /// <summary>
    /// Maneja la lista de los nuevos vendedores que ingresa 
    /// un lider por periodo
    /// </summary>
    public class NewSalesMan:List<vendedor>
    {
        private Data.SalesMan _SalesManAD;

        public NewSalesMan(String ConnectionString, String Lider, int Periodo)
        {
            _SalesManAD = new Data.SalesMan(ConnectionString);

            foreach (vendedor vend in _SalesManAD.GetNuevosReclutas(Lider,Periodo))
            {
                this.Add(vend);
            }
           
        }
    }
}

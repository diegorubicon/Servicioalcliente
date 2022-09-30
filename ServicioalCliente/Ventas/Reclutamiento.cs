using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SFC.SalesForceLib;
namespace Ventas
{
    public class Reclutamiento
    {
        private string _CnnStr;

        public Reclutamiento(string ConnectionString)
        {
            _CnnStr = ConnectionString;
        }
        public IEnumerable<SellerMan> ReclutasNuevos (int _Periodo, string Patrocinador)
        {
            Vendedores dm = new Vendedores();

           /* foreach (Sellerman v in dm.Where(c => c.Value = obj)
            {
                yield return v;
            }*/
            yield return null;
        }
    }
}

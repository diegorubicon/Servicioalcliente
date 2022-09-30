using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ventas.DataAccess
{
    public class DataQuery
    {
        private string _CnnStr;

        public DataQuery(string ConnectionString)
        {
            _CnnStr = ConnectionString;
        }
        public double QueryLinea1(string CodigoVendedor, int Cierre)
        {
            using (DataManager.SqlDataFunctions data = new DataManager.SqlDataFunctions(_CnnStr))
            {
                data.TableName = "facturas_encabezado";
                data.Fields = "SUM (monto_bruto) as linea1 ";
                data.SetFiltro("vendedor", DataManager.Signos.Igual, CodigoVendedor);
                data.SetFiltro("cierre", DataManager.Signos.Igual, Cierre);
                data.SetFiltro("estado", DataManager.Signos.Diferente, 4);
                data.SetFiltro("tipo", DataManager.Signos.Menor, 3);

                return data.RetrieveDouble();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vendedores.BusinessObjects.DataSource
{
    //tiene la funcion de enviar consultas a la base de datos 
    public class VentasQuery
    {
        private string _CnnStr;

        public VentasQuery(string ConnectionString)        
        {
            _CnnStr = ConnectionString;
        }
        public double QueryVentaLinea1(string Vendedor,int periodo)
        {
            using (DataManager.SqlDataFunctions sqldata = new DataManager.SqlDataFunctions(_CnnStr))
            {
                sqldata.TableName = "facturas_encabezado";
                sqldata.Fields = "SELECT ISNULL(SUM(monto_bruto),0) ";
                sqldata.SetFiltro("estado", DataManager.Signos.Diferente,4);
                sqldata.SetFiltro("tipo",DataManager.Signos.Menor,3);
                sqldata.SetFiltro("vendedor",DataManager.Signos.Igual,Vendedor);
                sqldata.SetFiltro("cierre",DataManager.Signos.Igual ,periodo);

                return sqldata.RetrieveDouble();
            }
        }
    }
}

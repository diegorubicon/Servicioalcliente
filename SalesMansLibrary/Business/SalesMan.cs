using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SalesMansLibrary.Business
{
    public class SalesMan:List<vendedor>
    {
        private Data.SalesMan _TableSalesMan;
        
        public SalesMan(String ConnectionString)
        {
            _TableSalesMan = new Data.SalesMan(ConnectionString);
        }
        /// <summary>
        /// Crea un objeto salesman y lo inicializa con los datos de la base de datos
        /// </summary>
        /// <param name="ConnectionString">Cadena de conexion a la base de datos</param>
        /// <param name="Code">Codigo de vendedor con el que se quiere inicializar los datos</param>
        /// 
        public SalesMan(String ConnectionString, String Code)
        {
            _TableSalesMan = new Data.SalesMan(ConnectionString);

            this.Clear () ;

            foreach (var vend in _TableSalesMan.GetRow(Code))
            {
                vendedor v = (vendedor)vend;
                this.Add(v);
            }
        }
        public void ApplyChanges()
        {
            _TableSalesMan.UpdateTables();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ventas
{
    public class VentaXPeriodo
    {
        private string _CnnStr;
        public int Periodo { get; set; }
        public string CodigoVendedor { get; set; }

        public VentaXPeriodo(string ConnectionString) { }
        public VentaXPeriodo(string ConnectionString,int _Periodo, string _CodigoVendedor)
        {
            this.Periodo = _Periodo;
            this.CodigoVendedor = _CodigoVendedor;
        }
        public double GetVentaLinea1()
        {
            DataAccess.DataQuery db = new DataAccess.DataQuery(_CnnStr);

            return db.QueryLinea1(this.CodigoVendedor,this.Periodo);
        }

    }
}

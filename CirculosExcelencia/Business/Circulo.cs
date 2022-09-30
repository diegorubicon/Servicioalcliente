using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CirculosExcelencia.Business
{
    public class Circulo:List<CirculoExcelencia>
    {
        private Data.Circulo _DataSource = null;

        public Circulo(String ConnectionString, String vendedor, Decimal CierreFinal)
        {
            _DataSource = new Data.Circulo(ConnectionString);

            CirculoExcelencia rst = null;

            rst = _DataSource.GetRowByVendedor(vendedor, CierreFinal);

            if (rst != null)
                this.Add(rst);

        }
    }
}

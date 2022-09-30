using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Facturacion.BusinessLayer
{
    public class Factura : Entities.Factura
    {
        private string _cnnstr;
        public Factura(string ConnectionString)
        {
            _cnnstr = ConnectionString;
        }
        public bool Load(string NumeroFactura)
        {
            using (DataAccess.FacturacionAD dao = new DataAccess.FacturacionAD(_cnnstr))
            {
                return dao.Load(NumeroFactura, this);
            }
        }

    }
}

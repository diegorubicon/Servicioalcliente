using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SalesForce.Business
{
    public class Vendedor : Entities.Vendedor
    {
        private string _cnnstr;
        public Vendedor(string ConnectionString)
        {
            _cnnstr = ConnectionString;
        }
        public bool Load(string id)
        {
            using ( DataAccess.VendedorAD objad = new DataAccess.VendedorAD(_cnnstr))
            {
                return objad.Fill(this,vendedor => vendedor.Id == id);
            }
        }
        public List<Entities.Vendedor> FilterByName(string PartOfName)
        {
            using (DataAccess.VendedorAD objad = new DataAccess.VendedorAD(_cnnstr))
            {
                return objad.FilterByName(PartOfName);
            }
        }
    }
}

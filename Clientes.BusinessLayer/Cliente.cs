using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TerritorialDivisionLib;

namespace Clientes.BusinessLayer
{
    public class Cliente : Entities.Cliente
    {
        private string _cnnstr;
        public Cliente(string ConnectionString)
        {
            _cnnstr = ConnectionString;
        }
        public bool Load(string CodigoCliente)
        {
            using (DataAccess.ClienteDA dao = new DataAccess.ClienteDA(_cnnstr))
            {
                return dao.Load(CodigoCliente, this);
            }
        }
        public List<Entities.Cliente> Filter(string criterio)
        {
            using (DataAccess.ClienteDA clientes = new DataAccess.ClienteDA(_cnnstr))
            {
                return clientes.Filter(criterio);
            }
        }
        public List<Entities.Cliente> FilterByAdress(Province prov,Canton cant,District dist)
        {
            if (prov != null)
            {
                using (DataAccess.ClienteDA clientes = new DataAccess.ClienteDA(_cnnstr))
                {
                    if (cant == null)
                        return clientes.Filter(c => c.provincia == prov.Id);
                    else
                        if (dist == null)
                            return clientes.Filter(c => c.provincia == prov.Id
                                           && c.canton == cant.Id);
                        else
                            return clientes.Filter(c => c.provincia == prov.Id
                                      && c.canton == cant.Id
                                      && c.distrito == dist.Id);
                }
            }
            else
                return new List<Entities.Cliente>();
        }
      
    }
}

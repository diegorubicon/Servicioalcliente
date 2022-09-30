using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq;

namespace TerritorialDivision.BusinessLayer
{
    public class Provincia :Entities.Provincia
    {
        private string _cnnstr;

        public Provincia(string ConnectionString)
        {
            _cnnstr = ConnectionString;
        }
        public List<Entities.Provincia> GetAll()
        {
            DataAccess.ProvinciasAD objad = new DataAccess.ProvinciasAD(_cnnstr);

            return objad.LoadAll();

        }
    }
}

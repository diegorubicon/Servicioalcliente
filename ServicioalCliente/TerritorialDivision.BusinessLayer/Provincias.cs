using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TerritorialDivision.BusinessLayer
{
    public class Provincias : IEnumerable<Entities.Provincia>
    {
        private string _cnnstr;
        private List<Entities.Provincia> _intlst;

        public Provincias(string ConnectionString)
        {
            _cnnstr = ConnectionString;
            _intlst = new List<Entities.Provincia>();
        }
        public Entities.Provincia this[decimal index]
        {
            get
            {
                if (_intlst.Count == 0)
                {
                    DataAccess.ProvinciasAD objad = new DataAccess.ProvinciasAD(_cnnstr);

                    Entities.Provincia prov = objad.Get(index);
                    if (prov != null)
                        _intlst.Add(prov);

                    return prov;
                }
                else
                    return null;
            }
        }

        IEnumerator<Entities.Provincia> IEnumerable<Entities.Provincia>.GetEnumerator()
        {
            Console.WriteLine("HERE");
            return null;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return null;
        }
   
    }
}

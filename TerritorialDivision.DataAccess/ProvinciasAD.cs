using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq;

namespace TerritorialDivision.DataAccess
{
    public class ProvinciasAD
    {
        private string _cnnstr;
        private DataContext db;
        public ProvinciasAD(string ConnectionString)
        {
            _cnnstr = ConnectionString;
            db = new DataContext(ConnectionString);
        }
        public Entities.Provincia Get(decimal id)
        {
            return db.GetTable<Entities.Provincia>().Where(c => c.Id == id).First();           
        }

        public List<Entities.Provincia> LoadAll()
        {
            using(DataContext db = new DataContext(_cnnstr))
            {
                try
                {
                    List<Entities.Provincia> _list = new List<Entities.Provincia>();

                    foreach (Entities.Provincia prov in db.GetTable<Entities.Provincia>())
                    {
                       
                        foreach (Entities.Canton cant in prov.Cantones)
                        {

                        }
                        _list.Add(prov);
                    }

                    return _list;
                }
                catch (Exception)
                {
                    return new List<Entities.Provincia>();
                }
            }
       }
    }
}

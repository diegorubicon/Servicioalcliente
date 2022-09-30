using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UserAccessManager
{
    //Tiene la responsabilidad de hacer operaciones basicas sobre perfiles
    class Perfiles
    {
        private string _cnnstr;

        public Perfiles(string ConnectionString)
        {
            _cnnstr = ConnectionString;
        }
        public List<Perfil> ToList() 
        {
            List<Perfil> lista = new List<Perfil>();

            PerfilStorage st = new PerfilStorage(_cnnstr);
            try
            {

                foreach (Perfil perfil in st.LoadAll())
                {
                    lista.Add(perfil);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo obtener los perfiles " + ex.Message);
            }
            return lista; 
        }
        public void Add(Perfil p)
        {
            PerfilStorage st = new PerfilStorage(_cnnstr);

            st.Add(ref p);
        }
        public void Update(Perfil p)
        {
            PerfilStorage st = new PerfilStorage(_cnnstr);

            st.Update(p);
        }
    }
}

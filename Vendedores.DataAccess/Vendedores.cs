
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Vendedores.BusinessObjects
{
    //to do: simplificar el
    public class Vendedores : Dictionary<string, Entities.Vendedor>
    {
        
        protected string _cnnstr;      

        public Vendedores(string ConnectionString)
        {
            _cnnstr = ConnectionString;            
        }
        public void Fill()
        {
            DataSource.DataExchange db = new DataSource.DataExchange(_cnnstr);

            foreach (Entities.Vendedor v in db.SelectAll())
            {               
                base.Add(v.Id, v);
            }
        }
        public Entities.Vendedor this [string CodigoVendedor]
        {
            get
            {
                if (this.ContainsKey(CodigoVendedor))
                    return base[CodigoVendedor];
                else
                {
                    DataSource.DataExchange db = new DataSource.DataExchange(_cnnstr);
                    Entities.Vendedor v = db.Get(CodigoVendedor);
                    if ( v != null)
                        base.Add(v.Id,v);

                    return v;
                }
            }
            set
            {

            }           
        }
       /* public void MakeFileVcf(string path)
        {
            using (StreamWriter sw = new StreamWriter(path, false, System.Text.Encoding.Default))
            {
                foreach (Vendedor v  in this.Values)
                {
                    sw.Write(v.vCard());
                }
            }
        }
        public void MakeFileCSV(string path)
        {
            using (StreamWriter sw = new StreamWriter(path, false, System.Text.Encoding.Default))
            {
                sw.WriteLine("\"Título\";\"Nombre\";\"Segundo nombre\";\"Apellido\";\"Sufijo\";\"Cargo\";\"Compañía\";\"Cumpleaños\";\"Dirección SIP\";\"Push-to-talk\";\"Compartir vista\";\"ID de usuario\";\"Notas\";\"Móvil general\";\"Teléfono general\";\"Correo general\";\"Fax general\";\"Llamada de video general\";\"Dirección Web general\";\"Dirección VOIP general\";\"Apartado de correo general\";\"Extensión general\";\"Calle general\";\"Código postal general\";\"Ciudad general\";\"Estado/provincia general\";\"País/región general\";\"Móvil particular\";\"Fijo particular\";\"Correo particular\";\"Fax particular\";\"Llamada de video particular\";\"Dirección Web particular\";\"Dirección VOIP particular\";\"Apartado postal particular\";\"Extensión particular\";\"Calle del domicilio\";\"Código postal particular\";\"Ciudad del domicilio\";\"Estado/provincia del domicilio\";\"País/región del domicilio\";\"Móvil trabajo\";\"Fijo trabajo\";\"Correo trabajo\";\"Fax del trabajo\";\"Llamada de video del trabajo\";\"Dirección Web del trabajo\";\"Dirección VOIP del trabajo\";\"Apartado postal del trabajo\";\"Extensión del trabajo\";\"Calle del trabajo\";\"Código postal del trabajo\";\"Ciudad del trabajo\";\"Estado/provincia del trabajo\";\"País/región del trabajo\";\"\"");
                foreach (Vendedor v in this.Values)
                {
                    sw.WriteLine(v.CSV());
                }
            }
        }*/
    }
}

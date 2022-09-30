using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EnvioSMS.Business
{
    public class Destinatario
    {
        private string _Nombre = "";       
        private string _Telefono = "";

        public Destinatario(string nombre,string telefono)
        {
            _Nombre = nombre;           
            _Telefono = telefono;
        }
        public string Nombre { get { return _Nombre; } set { _Nombre = value; } }       
        public string Telefono   { get { return _Telefono; }  set { _Telefono = value; } }
    }
}

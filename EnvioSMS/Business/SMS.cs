using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EnvioSMS.Business
{
    public class SMS
    {
        private int _id = 0;
        private string _mensaje = "";
        private DateTime _HoraEnvio;
        private DateTime _FechaEnvio;
        private List<Destinatario> _destinatarios;

        public string texto { get { return _mensaje; } set { _mensaje = value; } }
        public DateTime FechaEnvio { get { return _FechaEnvio; } set { _FechaEnvio = value; } }
        public DateTime HoraEnvio { get { return _HoraEnvio; } set { _HoraEnvio = value; } }
        public List<Destinatario> Destinatarios { get { return _destinatarios; } }

        public SMS()
        {
            _destinatarios = new List<Destinatario>() ;
            _mensaje = "";
            _HoraEnvio = DateTime.Now;
            _FechaEnvio = DateTime.Now.Date;
        }
        public SMS(string mensaje)
        {
            _destinatarios = new List<Destinatario>();
            _mensaje = mensaje;
            _HoraEnvio = DateTime.Now;
            _FechaEnvio = DateTime.Now.Date;
        }
        public SMS(string mensaje, DateTime HoraEnvio, DateTime FechaEnvio)
        {
            _destinatarios = new List<Destinatario>();
            _mensaje = mensaje;
            _HoraEnvio = HoraEnvio;
            _FechaEnvio = FechaEnvio;
        }

        public void AgregarDestinatario(Destinatario nuevodestinatario)
        {
            _destinatarios.Add(nuevodestinatario);
        }
        public void AgregarDestinatario(string NewNombre, string NewTelefono)
        {
            Destinatario d = new Destinatario(NewNombre, NewTelefono);

            _destinatarios.Add(d);
        }

     }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Actividades.Data
{
    public class ActividadDTO
    {
        int _id = -1;
        string _descripcion = "";
        string _ubicacion = "";
        DateTime _fecha;
        string _observaciones = "";
        IEnumerable<PersonaDTO> _asistentes;

        public int ID{ get{return _id;}set{ _id = value;}}
        public string Descripcion { get { return _descripcion; } set { _descripcion = value; } }
        public string Ubicacion { get { return _ubicacion; } set { _ubicacion = value; } }
        public DateTime Fecha { get { return _fecha; } set { _fecha = value; } }
        public string Observaciones { get { return _observaciones; } set { _observaciones = value; } }
        public IEnumerable<PersonaDTO> Asistentes { get { return _asistentes; } set { _asistentes = value; } }

        public class PersonaDTO
        {
            string _ID = "";
            string _nombre = "";
            public string ID { get { return _ID; } set { _ID = value; } }
            public string Nombre { get { return _nombre; } set { _nombre = value; } }    
        }

    }
}

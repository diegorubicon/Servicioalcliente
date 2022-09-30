using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common.Entities
{
    public class Persona
    {
        public string Codigo { get; set; }
        public string TipoIdentificacion { get; set; }
        public string Identificacion { get; set; }
        public string Nombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }        
        public string Telefono01 { get; set; }
        public string Telefono02 { get; set; }
        public string Telefono03 { get; set; }
        public string Telefono04 { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }      
        public DateTime FechaIngreso { get; set; }
        public Genero Genero { get; set; }
        public Adress Direccion { get; set; }
        public Estado Estado { get; set; }
        public DateTime FechaNacimiento { get; set; }

        public string NombreCompleto
        {
            get             
            {
                return Nombre + " " + PrimerApellido + " " + SegundoApellido;
            }
        }



    }
}

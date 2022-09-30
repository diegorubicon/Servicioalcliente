using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SalesForce.Entities
{
    public class Vendedor
    {
        [Generic.Entities.Atributo(Identificardor = true)]
        public string Id { get; set; }
        public string Nombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public string NombreCompleto
        {
            get
            {
                return Nombre + " " + PrimerApellido + " " + SegundoApellido;
            }
        }
    }
}

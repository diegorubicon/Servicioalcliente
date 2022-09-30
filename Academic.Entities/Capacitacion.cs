using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Academic.Entities
{
    public class Capacitacion
    {
        [Generic.Entities.Atributo(Identificardor = true)]
        public decimal Id { get; set; }
        public string Descripcion { get; set; }
        public List<Modulo> Modulos { get; set; }

        public Capacitacion()
        {
            Modulos = new List<Modulo>();
        }
    }
}

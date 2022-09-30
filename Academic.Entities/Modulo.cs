using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Academic.Entities
{
    public class Modulo
    {
        public decimal Id { get; set; }
        public int Prioriodad { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public List<Asistente> Asistentes { get; set; }

        public Modulo()
        {
            Asistentes = new List<Asistente>();
        }
    }
}

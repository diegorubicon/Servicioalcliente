using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common.Entities
{
    public class Adress
    {
        public string Especifica { get; set; }
        public Zona Zona { get; set; }
        public Provincia Provincia { get; set; }
    }
}

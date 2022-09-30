using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ubicaciones
{
    public class Ubicacion
    {
        public string Especifica;
        public Provincia Provincia {get; set;}

        public Ubicacion()
        {
            Provincia = new Provincia();
        }

    }
    
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ubicaciones
{
    public class Provincia :Distrito
    {
        public Canton Canton { get; set; }

        public Provincia()
        {
            Canton = new Canton();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ubicaciones
{
    public class Canton : Distrito
    {
        public Distrito Distrito { get; set; }

        public Canton()
        {
            Distrito = new Distrito();
        }
    }
}

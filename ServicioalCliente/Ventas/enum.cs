using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ventas
{
    public enum TiposRegla { VentaLinea1Acumulada, ReclutasNuevos, PeriodosActivo };

    public class Regla
    {
        public string Nombre { get; set; }
        public TiposRegla Tipo { get; set; }
        public Object Valor { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Clientes.Entities
{
    public class Cliente: Common.Entities.Persona
    {        
        public TipoCliente Tipo { get; set; }
        public string Descripcion { get; set; }
        public string Representante { get; set; }
        public decimal LimiteCredito { get; set; }
        public decimal Descuento { get; set; }
        public decimal Plazo { get; set; }
        public string IdVendedorAsignado { get; set; }
        public int AceptaImpuesto { get; set; }
        public string Observaciones { get; set; }
        public int MuestraObservaciones { get; set; } 

       
    }
}

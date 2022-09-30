using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common.Entities;
namespace Facturacion.Entities
{
    public class Factura
    {
        public string Numero { get; set; }
        public TipoFactura Tipo { get; set; }
        public Persona Cliente { get; set; }
        public string IdVendedor { get; set; }
        public string IdCobrador { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public decimal Cierre { get; set; }
        public decimal Plazo { get; set; }
        public Estado Estado { get; set; }
        public decimal SubtotalConImpuesto { get; set; }
        public decimal SubtotalSinImpuesto { get; set; }
        public decimal TotalImpuestoVentas { get; set; }
        public decimal MontoDescuento { get; set; }
        public decimal MontoIntereses { get; set; }
        public decimal SaldoIntereses { get; set; }
        public decimal MontoBruto { get; set; }
        public decimal MontoTotal { get; set; }
        public decimal SaldoTotal { get; set; }


       
    }
}

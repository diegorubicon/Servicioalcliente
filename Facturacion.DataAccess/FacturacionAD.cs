using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using Common.Entities;


namespace Facturacion.DataAccess
{
    public class FacturacionAD : GenericDAO<facturas_encabezado, Entities.Factura>
    {
        private string cnnstr;   
        public FacturacionAD(string ConnectionString)
            : base(ConnectionString)
        {
            cnnstr = ConnectionString;
        }
        protected override facturas_encabezado CastToLinq(Entities.Factura f)
        {
            return new facturas_encabezado
            {
                Cierre = f.Cierre,                
                cobrador = f.IdCobrador,
                estado = f.Estado.Id,
                factura = f.Numero,
                fecha = f.Fecha,
                fecha_vencimiento = f.FechaVencimiento,
                meses_plazo = f.Plazo,
                monto_bruto = f.MontoBruto,
                monto_descuento_factura = f.MontoDescuento,
                monto_intereses_por_mora = f.MontoIntereses,
                monto_total = f.MontoTotal,
                saldo_intereses_por_mora = f.SaldoIntereses,
                saldo_factura = f.SaldoTotal,
                subtotal_con_impuesto = f.SubtotalConImpuesto,
                subtotal_sin_impuesto = f.SubtotalSinImpuesto,
                tipo = f.Tipo.Id,
                total_impuesto_ventas = f.TotalImpuestoVentas,
                vendedor = f.IdVendedor
            };
        }
       
        protected override IEnumerable<Entities.Factura> SelectToEntity()
        {
            var query = from fact in db.facturas_encabezados
                        select new Entities.Factura
                        {
                            Cierre = fact.Cierre.HasValue ? fact.Cierre.Value : 0,
                            Estado = new Entities.Estado
                            {
                                Id = fact.tipos_de_estado.estado,
                                Nombre = fact.tipos_de_estado.descripcion
                            },
                            Fecha = fact.fecha,
                            FechaVencimiento = fact.fecha_vencimiento.HasValue ? fact.fecha_vencimiento.Value : fact.fecha,
                            Cliente = new Persona
                            {
                                Codigo = fact.cliente1.cliente1,
                                Nombre = fact.cliente1.nombre,
                                PrimerApellido = fact.cliente1.apellido_01,
                                SegundoApellido = fact.cliente1.apellido_02,
                                Telefono01 = fact.cliente1.telefono_01,
                                Telefono02 = fact.cliente1.telefono_02,
                                Telefono03 = fact.cliente1.telefono_03,
                                Telefono04 = fact.cliente1.telefono_04,
                                Fax = fact.cliente1.fax,
                                Direccion = new Common.Entities.Adress
                                {
                                    Especifica = fact.cliente1.direccion,
                                    Provincia = new Common.Entities.Provincia
                                    {
                                        id = fact.cliente1.provincia1.provincia1,
                                        Nombre = fact.cliente1.provincia1.descripcion,
                                        Canton = new Common.Entities.Canton
                                        {
                                            id = fact.cliente1.cantone.canton,
                                            Nombre = fact.cliente1.cantone.descripcion,
                                            Distrito = new Common.Entities.CommonPlace
                                            {
                                                id = fact.cliente1.distrito1.distrito1,
                                                Nombre = fact.cliente1.distrito1.descripcion
                                            }
                                        }
                                    }
                                }
                            },
                            IdVendedor = fact.vendedor,
                            IdCobrador = fact.cobrador,
                            MontoBruto = fact.linea1.HasValue ? fact.linea1.Value : 0,
                            MontoDescuento = fact.monto_descuento_factura.HasValue ? fact.monto_descuento_factura.Value : 0,
                            MontoIntereses = fact.monto_intereses_por_mora.HasValue ? fact.monto_intereses_por_mora.Value : 0,
                            MontoTotal = fact.monto_total.HasValue ? fact.monto_total.Value : 0,
                            Numero = fact.factura,
                            Plazo = fact.meses_plazo.HasValue ? fact.meses_plazo.Value : 0,
                            SaldoIntereses = fact.saldo_intereses_por_mora.HasValue ? fact.saldo_intereses_por_mora.Value : 0,
                            SaldoTotal = fact.saldo_factura.HasValue ? fact.saldo_factura.Value : 0,
                            SubtotalConImpuesto = fact.subtotal_con_impuesto.HasValue ? fact.subtotal_con_impuesto.Value : 0,
                            SubtotalSinImpuesto = fact.subtotal_sin_impuesto.HasValue ? fact.subtotal_sin_impuesto.Value : 0,
                            Tipo = new Entities.TipoFactura
                            {
                                Id = fact.tipos_de_factura.tipo,
                                Nombre = fact.tipos_de_factura.descripcion
                            },
                            TotalImpuestoVentas = fact.total_impuesto_ventas.HasValue ? fact.total_impuesto_ventas.Value : 0
                        };
            return query;

        }

        public bool Load(string NumeroFactura, Entities.Factura ContainerDestiny)
        {
            try
            {
                Entities.Factura rst = SelectToEntity().Where(p => p.Numero == NumeroFactura).First();

                PropertyDescriptorCollection originalProps = TypeDescriptor.GetProperties(rst);

                foreach (PropertyDescriptor currentProp in originalProps)
                {
                    object val = currentProp.GetValue(rst);

                    currentProp.SetValue(ContainerDestiny, val);
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}

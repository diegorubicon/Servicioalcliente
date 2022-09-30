using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Data.Linq.SqlClient;

namespace Clientes.DataAccess
{
    public class ClienteDA : GenericDAO<t_cliente,Entities.Cliente>
    {
        public ClienteDA(string ConnectionString) : base(ConnectionString)
        {
           
        }
        protected override t_cliente CastToLinq(Entities.Cliente c)
        {
            return new t_cliente
            {
                
                acepta_impuesto = c.AceptaImpuesto,
                apellido_01 = c.PrimerApellido,
                apellido_02 = c.SegundoApellido,
                canton = c.Direccion.Provincia.Canton.id,
                codigo = c.Codigo,
                descripcion = c.Descripcion,
                descuento_general = c.Descuento,
                dias_plazo = c.Plazo,
                direccion = c.Direccion.Especifica,
                distrito = c.Direccion.Provincia.Canton.Distrito.id,
                email = c.Email,
                estado = c.Estado.Id,
                fax = c.Fax,
                fecha = c.FechaIngreso,
                fecha_nacimiento = c.FechaNacimiento,
                genero = c.Genero.Id,
                identificacion = c.Identificacion,
                limite_de_credito = c.LimiteCredito,
                mostrar_obs_fact = c.MuestraObservaciones,
                nombre = c.Nombre,
                observaciones = c.Observaciones,
                provincia = c.Direccion.Provincia.id,
                representante = c.Representante,
                telefono_01 = c.Telefono01,
                telefono_02 = c.Telefono02,
                telefono_03 = c.Telefono03,
                telefono_04 = c.Telefono04,
                tipo = c.Tipo.Id,
                tipo_de_identificacion = c.TipoIdentificacion, 
                vendedor = c.IdVendedorAsignado,
                zona = c.Direccion.Zona.Id
            };
        }
        protected override IEnumerable<t_cliente> Select()
        {
            return from cliente in db.t_clientes
                   select cliente;
        }      
        protected override IEnumerable<Entities.Cliente> SelectToEntity()
        {
            var query = from c in db.t_clientes
                        select new Entities.Cliente
                        {
                            AceptaImpuesto = c.acepta_impuesto.HasValue ? c.acepta_impuesto.Value : 0,
                            PrimerApellido = c.apellido_01,
                            SegundoApellido = c.apellido_02,
                            Codigo = c.codigo,
                            Descripcion = c.descripcion,
                            Direccion = new Common.Entities.Adress
                            {
                                Especifica = c.direccion,
                                Zona = new Common.Entities.Zona
                                {

                                },
                                Provincia = new Common.Entities.Provincia
                                {
                                    id = c.provincia1.provincia1,
                                    Nombre = c.provincia1.descripcion,
                                    Canton = new Common.Entities.Canton
                                    {
                                        id = c.cantone.canton,
                                        Nombre = c.cantone.descripcion,
                                        Distrito = new Common.Entities.CommonPlace
                                        {
                                            id = c.distrito1.distrito1,
                                            Nombre = c.distrito1.descripcion
                                        }
                                    }
                                }
                            },
                            Descuento = c.descuento_general.HasValue ? c.descuento_general.Value : 0,
                            Plazo = c.dias_plazo.HasValue ? c.dias_plazo.Value : 0,
                            Email = c.email,
                            Estado = new Common.Entities.Estado
                            {
                                Id = c.Tipos_de_estado_cliente.tipo,
                                Nombre = c.Tipos_de_estado_cliente.descripcion
                            },
                            Fax = c.fax,
                            FechaIngreso = c.fecha.HasValue ? c.fecha.Value : Convert.ToDateTime("01/01/1900"),
                            FechaNacimiento = c.fecha_nacimiento.HasValue ? c.fecha_nacimiento.Value : Convert.ToDateTime("01/01/1900"),
                            Genero = new Common.Entities.Genero
                            {
                                Id = c.genero.HasValue ? c.genero.Value : 0
                            },
                            Identificacion = c.identificacion,
                            LimiteCredito = c.limite_de_credito.HasValue ? c.limite_de_credito.Value : 0,
                            MuestraObservaciones = c.mostrar_obs_fact.HasValue ? c.mostrar_obs_fact.Value : 0,
                            Nombre = c.nombre,
                            Observaciones = c.observaciones,
                            Representante = c.representante,
                            Telefono01 = c.telefono_01,
                            Telefono02 = c.telefono_02,
                            Telefono03 = c.telefono_03,
                            Telefono04 = c.telefono_04,
                            Tipo = new Entities.TipoCliente
                            {
                                Id = c.tipos_de_cliente.tipo,
                                Nombre = c.tipos_de_cliente.descripcion
                            },
                            TipoIdentificacion = c.tipo_de_identificacion,
                            IdVendedorAsignado = c.vendedor
                        };
            return query;
        }    
        public bool Load(string CodigoCliente, Entities.Cliente ContainerDestiny)
        {
            try
            {
                Entities.Cliente rst = SelectToEntity().Where(p => p.Codigo == CodigoCliente).First();               

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
        private Entities.Cliente  MakeNewCliente (t_cliente c)
        {
            return new Entities.Cliente
            {
              
                
             
                AceptaImpuesto = c.acepta_impuesto.HasValue ? c.acepta_impuesto.Value : 0,
                    PrimerApellido = c.apellido_01,
                    SegundoApellido = c.apellido_02,
                    Codigo= c.codigo,
                    Descripcion = c.descripcion,
                    Direccion = new Common.Entities.Adress
                    {
                        Especifica = c.direccion,
                        Zona = new Common.Entities.Zona
                        {
                                    
                        },
                        Provincia = new Common.Entities.Provincia
                        {
                            id = c.provincia1.provincia1,
                            Nombre = c.provincia1.descripcion,
                            Canton = new Common.Entities.Canton
                            {
                                id = c.cantone.canton,
                                Nombre = c.cantone.descripcion,
                                Distrito = new Common.Entities.CommonPlace
                                {
                                    id= c.distrito1.distrito1,
                                    Nombre = c.distrito1.descripcion
                                }
                            }
                        }
                    },
                    Descuento = c.descuento_general.HasValue ? c.descuento_general.Value : 0,
                    Plazo = c.dias_plazo.HasValue ? c.dias_plazo.Value : 0 ,                            
                    Email = c.email,
                    Estado = new Common.Entities.Estado
                    {
                        Id = c.Tipos_de_estado_cliente.tipo,
                        Nombre = c.Tipos_de_estado_cliente.descripcion
                    },                          
                    Fax = c.fax,
                    FechaIngreso = c.fecha.HasValue ? c.fecha.Value : Convert.ToDateTime("01/01/1900"),
                    FechaNacimiento = c.fecha_nacimiento.HasValue ? c.fecha_nacimiento.Value : Convert.ToDateTime("01/01/1900"),
                    Genero = new Common.Entities.Genero
                    {
                        Id = c.genero.HasValue ? c.genero.Value : 0 
                    },
                    Identificacion = c.identificacion,
                    LimiteCredito = c.limite_de_credito.HasValue ? c.limite_de_credito.Value : 0 ,
                    MuestraObservaciones = c.mostrar_obs_fact.HasValue ? c.mostrar_obs_fact.Value : 0,
                    Nombre = c.nombre,
                    Observaciones = c.observaciones,                            
                    Representante = c.representante,
                    Telefono01 = c.telefono_01 ,
                    Telefono02 = c.telefono_02 ,
                    Telefono03 = c.telefono_03 ,
                    Telefono04 = c.telefono_04,
                    Tipo = new Entities.TipoCliente
                    {
                        Id = c.tipos_de_cliente.tipo,
                        Nombre = c.tipos_de_cliente.descripcion
                    },                            
                    TipoIdentificacion = c.tipo_de_identificacion ,
                    IdVendedorAsignado = c.vendedor                        

            };
       
        }

        public List<Entities.Cliente> Filter(Func<t_cliente, bool> ConditionFilter)
        {
            var query = from c in db.t_clientes.Where(ConditionFilter)
                        select MakeNewCliente(c);
            try
            {
                return query.ToList();
            }
            catch (Exception)
            {
                return new List<Entities.Cliente>();
            }

        }

        public List<Entities.Cliente> Filter(string Criterio)
        {
            Criterio = Criterio.Replace(" ", "%");
            Criterio = "%" + Criterio + "%";
            
            var query = from c in db.t_clientes
                        where SqlMethods.Like(c.codigo, Criterio)
                        || SqlMethods.Like(c.nombre + c.apellido_01 + c.apellido_02, Criterio)
                        select new Entities.Cliente
                        {
                            AceptaImpuesto = c.acepta_impuesto.HasValue ? c.acepta_impuesto.Value : 0,
                            PrimerApellido = c.apellido_01,
                            SegundoApellido = c.apellido_02,
                            Codigo= c.codigo,
                            Descripcion = c.descripcion,
                            Direccion = new Common.Entities.Adress
                            {
                                Especifica = c.direccion,
                                Zona = new Common.Entities.Zona
                                {
                                    
                                },
                                Provincia = new Common.Entities.Provincia
                                {
                                    id = c.provincia1.provincia1,
                                    Nombre = c.provincia1.descripcion,
                                    Canton = new Common.Entities.Canton
                                    {
                                        id = c.cantone.canton,
                                        Nombre = c.cantone.descripcion,
                                        Distrito = new Common.Entities.CommonPlace
                                        {
                                            id= c.distrito1.distrito1,
                                            Nombre = c.distrito1.descripcion
                                        }
                                    }
                                }
                            },
                            Descuento = c.descuento_general.HasValue ? c.descuento_general.Value : 0,
                            Plazo = c.dias_plazo.HasValue ? c.dias_plazo.Value : 0 ,                            
                            Email = c.email,
                            Estado = new Common.Entities.Estado
                            {
                                Id = c.Tipos_de_estado_cliente.tipo,
                                Nombre = c.Tipos_de_estado_cliente.descripcion
                            },                          
                            Fax = c.fax,
                            FechaIngreso = c.fecha.HasValue ? c.fecha.Value : Convert.ToDateTime("01/01/1900"),
                            FechaNacimiento = c.fecha_nacimiento.HasValue ? c.fecha_nacimiento.Value : Convert.ToDateTime("01/01/1900"),
                            Genero = new Common.Entities.Genero
                            {
                                Id = c.genero.HasValue ? c.genero.Value : 0 
                            },
                            Identificacion = c.identificacion,
                            LimiteCredito = c.limite_de_credito.HasValue ? c.limite_de_credito.Value : 0 ,
                            MuestraObservaciones = c.mostrar_obs_fact.HasValue ? c.mostrar_obs_fact.Value : 0,
                            Nombre = c.nombre,
                            Observaciones = c.observaciones,                            
                            Representante = c.representante,
                            Telefono01 = c.telefono_01 ,
                            Telefono02 = c.telefono_02 ,
                            Telefono03 = c.telefono_03 ,
                            Telefono04 = c.telefono_04,
                            Tipo = new Entities.TipoCliente
                            {
                                Id = c.tipos_de_cliente.tipo,
                                Nombre = c.tipos_de_cliente.descripcion
                            },                            
                            TipoIdentificacion = c.tipo_de_identificacion ,
                            IdVendedorAsignado = c.vendedor
                            
                        };
            try
            {
                return query.ToList();
            }
            catch (Exception)
            {
                return new List<Entities.Cliente>() ;
            }

        }


    }
}

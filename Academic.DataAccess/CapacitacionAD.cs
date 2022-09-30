using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Academic.DataAccess
{
    public class CapacitacionAD : GenericDAO<Capacitacion,Entities.Capacitacion>
    {
        public CapacitacionAD(string ConnectionString) : base(ConnectionString) { }
        
        protected override IEnumerable<Entities.Capacitacion> SelectToEntity()
        {
            return from cap in db.Capacitacions
                   select new Entities.Capacitacion
                   {
                       Id = cap.id,
                       Descripcion = cap.descripcion,
                       Modulos = (from m in cap.Capacitacion_modulos
                                  select new Entities.Modulo
                                  {
                                      Id = m.id_modulo,
                                      Prioriodad = m.prioridad.HasValue ? m.prioridad.Value : 0,
                                      Nombre = m.nombre,
                                      Descripcion = m.descripcion,
                                      Asistentes = (from a in m.capacitacion_modulos_vendedores
                                                    select new Entities.Asistente
                                                    {
                                                        Vendedor = a.vendedor,
                                                        Nombre = a.vendedore.nombre+" "+a.vendedore.apellido_01+" "+a.vendedore.apellido_02,
                                                        Fecha = a.fecha.HasValue ? a.fecha.Value : DateTime.Now
                                                    }).ToList()
                                  }).ToList()
                   };
        }
        protected override Entities.Capacitacion CastToEntity(Capacitacion cap)
        {
            return new Entities.Capacitacion
                   {
                       Id = cap.id,
                       Descripcion = cap.descripcion,
                       
                       Modulos = (from m in cap.Capacitacion_modulos
                                  select new Entities.Modulo
                                  {
                                      Id = m.id_modulo,
                                      Prioriodad = m.prioridad.HasValue ? m.prioridad.Value : 0,
                                      Nombre = m.nombre,
                                      Descripcion = m.descripcion,
                                      Asistentes = (from a in m.capacitacion_modulos_vendedores
                                                    select new Entities.Asistente
                                                    {
                                                        Vendedor = a.vendedor,
                                                        Fecha = a.fecha.HasValue ? a.fecha.Value : DateTime.Now,
                                                        Nombre = a.vendedore.nombre + " " + a.vendedore.apellido_01 + " " + a.vendedore.apellido_02
                                                    }).ToList()
                                  }).ToList()
                   };
        }
        protected override Capacitacion CastToLinq(Entities.Capacitacion p)
        {
            Capacitacion cap = new Capacitacion();

            cap.id = p.Id;
            cap.descripcion = p.Descripcion;
            cap.Capacitacion_modulos = new System.Data.Linq.EntitySet<Capacitacion_modulo> ();
          
            foreach (Entities.Modulo m in p.Modulos)
            {
                Capacitacion_modulo cm = new Capacitacion_modulo();
                cm.id_modulo = m.Id;
                cm.prioridad = m.Prioriodad;
                cm.nombre = m.Nombre;
                cm.descripcion = m.Descripcion;
                cm.capacitacion_modulos_vendedores = new System.Data.Linq.EntitySet<capacitacion_modulos_vendedore>();
                foreach (Entities.Asistente a in m.Asistentes)
                {
                    cm.capacitacion_modulos_vendedores.Add(new capacitacion_modulos_vendedore { vendedor = a.Vendedor, fecha = a.Fecha });
                }
                cap.Capacitacion_modulos.Add(cm);
            }
            return cap;
        }

        public void AddAsistente(Entities.Capacitacion cap, Entities.Modulo m ,Entities.Asistente asis)
        {
            try
            {
                var query = from c in db.Capacitacions
                            where c.id == cap.Id
                            select c;
                if (query.Count() > 0)
                {
                    Capacitacion orig = query.First();

                    foreach (Capacitacion_modulo cp in orig.Capacitacion_modulos)
                    {
                        if (cp.id_modulo == m.Id)
                        {
                            cp.capacitacion_modulos_vendedores.Add(new capacitacion_modulos_vendedore { vendedor = asis.Vendedor, fecha = asis.Fecha });
                        }
                    }
                    db.SubmitChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void DeleteAsistente(Entities.Capacitacion cap, Entities.Modulo m, Entities.Asistente asis)
        {
            try
            {
                var query = from a in db.capacitacion_modulos_vendedores
                            where a.id_capacitacion == cap.Id && a.id_modulo == m.Id && a.vendedor == asis.Vendedor
                            select a;
                if (query.Count() > 0)
                {
                    db.capacitacion_modulos_vendedores.DeleteOnSubmit(query.First());

                    db.SubmitChanges();
                }
            }
            catch (Exception)
            {
                throw;
            } 
        }
    }
}

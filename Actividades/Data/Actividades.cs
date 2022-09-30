using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Actividades.Data
{
    class Actividades
    {
        private DataModelDataContext db = null;

        public Actividades(String ConnectionString)
        {
            db = new DataModelDataContext(ConnectionString);        
        }

        public IEnumerable<ActividadDTO> ObtenerTodas()
        {
      
                var query = from act in db.actividads
                            select new ActividadDTO
                            {
                                ID = (int)act.id,
                                Descripcion = act.descripcion,
                                Fecha = act.fecha.GetValueOrDefault(DateTime.Now),
                                Observaciones = act.observaciones,
                                Ubicacion = act.ubicacion,
                                Asistentes = from per in act.actividades_vendedores
                                             select new ActividadDTO.PersonaDTO
                                             {
                                                  ID = per.vendedor,
                                                  Nombre = per.vendedor1.nombre
 
                                             }
                                             

                            };
                return query;
                     
        }
    }
}

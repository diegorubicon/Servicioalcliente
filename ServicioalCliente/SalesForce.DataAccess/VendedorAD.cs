using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq.SqlClient;

namespace SalesForce.DataAccess
{
    public class VendedorAD : GenericDAO <Vendedor,Entities.Vendedor>
    {
        public VendedorAD(string ConnectionString) : base(ConnectionString) { }

        protected override Entities.Vendedor CastToEntity(Vendedor p)
        {
            return new Entities.Vendedor
            {
                Id = p.id,
                Nombre = p.nombre,
                PrimerApellido = p.apellido_01,
                SegundoApellido = p.apellido_02
            };
        }
        protected override Vendedor CastToLinq(Entities.Vendedor p)
        {
            return new Vendedor
            {
                id = p.Id,
                nombre = p.Nombre,
                apellido_01 = p.PrimerApellido,
                apellido_02 = p.SegundoApellido
            };
        }
        protected override IEnumerable<Entities.Vendedor> SelectToEntity()
        {
            return from v in db.Vendedors
                   select CastToEntity(v);

        }

        public List<Entities.Vendedor> FilterByName(string PartOfName)
        {
            PartOfName = PartOfName.Replace(" ", "%");
            PartOfName = "%" + PartOfName + "%";
            var query = from v in db.Vendedors
                        where SqlMethods.Like(v.nombre + v.apellido_01 + v.apellido_02, PartOfName)
                        select CastToEntity(v);
            try
            {
                return query.ToList();
            }
            catch (Exception)
            {
                return new List<Entities.Vendedor>();
            }
        }
        

    }
}

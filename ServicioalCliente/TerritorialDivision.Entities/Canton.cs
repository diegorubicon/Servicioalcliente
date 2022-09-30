using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace TerritorialDivision.Entities
{
    [Table(Name = "Cantones")]
    public class Canton 
    {
        [Column(Name = "provincia", IsPrimaryKey = true)]
        public int Id_provincia { get; set; }

        [Column(Name = "canton", IsPrimaryKey = true)]
        public int Id { get; set; }

        [Column(Name = "descripcion")]
        public string Descripcion { get; set; }

        private EntitySet<Distrito> _distritos;

        [AssociationAttribute(Name = "cantones_distritos", Storage = "_distritos", ThisKey = "Id_provincia,Id", OtherKey = "Id_provincia,Id_canton")]
        public EntitySet<Distrito> Distritos
        {
            get { return _distritos; }
            set { _distritos.Assign(value); }
        }     
        public Canton()
        {            
        }      
    }
}

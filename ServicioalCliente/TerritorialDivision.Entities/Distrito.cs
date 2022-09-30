using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace TerritorialDivision.Entities
{
    [Table(Name = "dbo.Distritos")]
    public class Distrito
    {
        [Column(Name = "provincia", IsPrimaryKey = true)]
        public int Id_provincia { get; set; }

        [Column(Name = "canton", IsPrimaryKey = true)]
        public int Id_canton { get; set; }

        [Column(Name = "distrito", IsPrimaryKey = true)]
        public int Id { get; set; }

        [Column(Name = "descripcion")]
        public string Descripcion { get; set; }

        

    }
}

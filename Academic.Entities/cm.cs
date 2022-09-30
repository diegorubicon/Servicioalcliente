using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq.Mapping;

namespace Academic.Entities
{
    [Table(Name = "capacitacion_modulos")]
    public class cm
    {
       [global::System.Data.Linq.Mapping.ColumnAttribute(Name="id_capacitacion", IsPrimaryKey=true)]
        public decimal id_capacitacion { get; set; }
        [Column(Name = "id_modulo", IsPrimaryKey = true)]
        public decimal id_modulo { get; set; }
        [Column(Name = "nombre")]
        public string Nombre { get; set; }
        [Column(Name = "descripcion")]
        public string descripcion { get; set; }

    }
}

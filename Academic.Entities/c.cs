using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace Academic.Entities
{

    [Table(Name = "Capacitaciones")]
    public class c
    {   
        [Column(Name="id", IsPrimaryKey = true, IsDbGenerated = true)]
        public decimal id { get; set; }
        [Column(Name= "descripcion")]
        public string Descripcion { get; set; }

        [Association(ThisKey = "id", OtherKey = "id_capacitacion")]
        public EntitySet<cm> Modulos {get;set;}
        
        public c()
        {
            this.Modulos = new EntitySet<cm>();        
        }      
        
    }
}

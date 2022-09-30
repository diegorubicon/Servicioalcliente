using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicioalCliente.Infrastructure.DTO
{
    [Table("parametros_default")]
    public class AppParameterDTO
    {
        [Column("Pais")]
        public string Country { get; set; }
    }
}

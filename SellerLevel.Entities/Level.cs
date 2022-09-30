using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataWarehouseLib;

namespace SellerLevel.Entities
{
    public class Level
    {
        [DataAccessFieldAttribute("nivel02", DataAccessFieldAttribute.Type.Integer)]
        public int Id { get; set; }
        [DataAccessFieldAttribute("descripcion", DataAccessFieldAttribute.Type.Varchar)]
        public string Description { get; set; }

        public Level()
        {
        }
    }
}

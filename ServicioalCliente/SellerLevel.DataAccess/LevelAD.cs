using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataWarehouseLib.MSSQL;


namespace SellerLevel.DataAccess
{
    public class LevelAD<T> : DataTableBroker<T>
        where T: SellerLevel.Entities.Level, new()
    {

        public LevelAD() 
        {
            base.CustomQuery = "SELECT v.nivel02,pmn.descripcion FROM vendedores v, plan_mercadeo_niveles pmn WHERE v.planmercadeoactual = pmn.plan_mercadeo and v.nivel02 = pmn.nivel ";
        }             
   }
}

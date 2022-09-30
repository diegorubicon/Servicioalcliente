using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SellerLevel.BusinessLayer
{
    public class MarketingPlanLevels
    {
        public Level getLevelOf(String IdSalesMan)
        {
            DataAccess.LevelAD<Level> ad = new DataAccess.LevelAD<Level>();
            ad.Where.Add(new DataAccess.Filters.IdSalesManFilter(IdSalesMan));

            return ad.getFirst();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sales.Opportunities
{
    public class SalesOpportunities : List<SalesOpportunity>
    {

        public SalesOpportunities(string ConnectionString)
        {
            OpportunityStorageSqlClient ad = new OpportunityStorageSqlClient(ConnectionString);

            ad.Fill(this);

        }
        /// <summary>
        /// Crea una nueva lista de oportunidades asignadas al distribudor 
        /// </summary>
        /// <param name="AssignedDealer">Codigo del distribuidor al que se le asignaron las oportunidades</param>
        public SalesOpportunities(string ConnectionString, string AssignedDealer)
        {
            OpportunityStorageSqlClient ad = new OpportunityStorageSqlClient(ConnectionString);

            ad.Fill(this, AssignedDealer);
        }
    }
}

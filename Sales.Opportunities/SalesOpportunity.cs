using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TerritorialDivisionLib;

namespace Sales.Opportunities
{
    public class SalesOpportunity
    {
        public string Id { get; set; }
        public Contact Contact { get; set; }
        public string identificacion { get; set; }

        public string direccion { get; set; }

        public Province Provincia { get; set; }        
        public Canton Canton { get; set; }
        public District Distrito { get; set; }

        public string DistribuidorAsignado {get;set;}


    }
}

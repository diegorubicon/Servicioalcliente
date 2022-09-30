using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AfterSales.Model
{
    public class DisableTrackings
    {
        public decimal Sequent { get; set; }
        public string PurchaseOrderNumber { get; set; }
        public DisableTrackingCustomer Customer { get; set; }
        public decimal ClosingSequent { get; set; }
        public decimal LastArrangement { get; set; }
        public DateTime DisableTime { get; set; }
        public string DisableBy { get; set; }
        public string LastNote { get; set; }
        public decimal Status { get; set; }
        public DisableTrackings()
        {
            Customer = new DisableTrackingCustomer();
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AfterSales.Model
{
    public class AfterSalesAccount
    {
        public class PurchaseOrderAccount
        {
            public string Number { get; set; }
            public int Type { get; set; }
            public DateTime DateOfAdmission { get; set; }
            public DateTime? LastPaymentDate { get; set; }
        }
        public class CustomerAccount
        {
            public class CustomerInteres
            {
                public string Id { get; set; }
                public string Name { get; set; }

            }
            public string Id { get; set; }
            public string Name { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public CustomerInteres Interes { get; set; }
            public string CreditLevel { get; set; }
            public string Province { get; set; }
            public string City { get; set; }
            public string HomePhoneNumber { get; set; }
            public string CellPhoneNumber { get; set; }
           
            public override string ToString()
            {
                return Name + " " + FirstName + " " + LastName;
            }
            public CustomerAccount()
            {
                Interes = new CustomerInteres();
            }
        }
        public class SalesManAccount
        {
            public string Id { get; set; }
            public string Name { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }

            public override string ToString()
            {
                return Name + " " + FirstName + " " + LastName;
            }
        }

        public PurchaseOrderAccount PurchaseOrder { get; set; }
        public CustomerAccount Customer { get; set; }
        public SalesManAccount SalesMan { get; set; }

        public DateTime NextCallDate { get; set; }
        public string LastManager { get; set; }
        public string LastCallStatus { get; set; }

        public DateTime? OpportunityDate { get; set; }

        public int DaysOfCancellation()
        {
            if (PurchaseOrder.LastPaymentDate.HasValue)
                return (DateTime.Now - PurchaseOrder.LastPaymentDate.Value).Days;
            else
                return -1;
        }
        public AfterSalesAccount()
        {
            PurchaseOrder = new PurchaseOrderAccount();
            Customer = new CustomerAccount();
            SalesMan = new SalesManAccount();
        }
    }
}

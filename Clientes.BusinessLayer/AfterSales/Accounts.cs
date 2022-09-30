using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AfterSales.Repositories.AdoRepositories;

namespace AfterSales
{
    public class Accounts
    {
        private AfterSalesAccountRepository asar;
        private const int LapseSpotOrders = 30;
        private const int CreditSpanOrders = 15;
        private string _gestor;
        public Accounts(string gestor)
        {
            asar = new AfterSalesAccountRepository();
            _gestor = gestor;
        }
        public IEnumerable<Model.AfterSalesAccount> ToList()
        {
            foreach (Model.AfterSalesAccount asa in ToList(0,0,0))
            {
                yield return asa;
            }
        }
        public IEnumerable<Model.AfterSalesAccount> ToList(int province)
        {
            foreach (Model.AfterSalesAccount asa in ToList(province, 0, 0))
            {
                yield return asa;
            }
        }
        public IEnumerable<Model.AfterSalesAccount> ToList(int province,int city)
        {
            foreach (Model.AfterSalesAccount asa in ToList(province, city, 0))
            {
                yield return asa;
            }
        }
        public IEnumerable<Model.AfterSalesAccount> ToList(int provincia,int canton,int distrito)
        {
            PortfolioAfterSales cartera = new PortfolioAfterSales(_gestor);
            //obtiene todas las cuentas postventa       
            asar.SetFilter(AfterSalesAccountRepository.FieldFilter.Province, provincia);
            asar.SetFilter(AfterSalesAccountRepository.FieldFilter.City, canton);
            asar.SetFilter(AfterSalesAccountRepository.FieldFilter.District, distrito);

            foreach (Model.AfterSalesAccount acc in asar.GetAllAccounts())
            {
                //Verifica si el vendedor existe en la cartera del vendedor
                if (cartera.Exist(acc.SalesMan.ToString()))
                {
                    //aplica las reglas de negocio y retorna solo los valores deseados
                    if (acc.PurchaseOrder.LastPaymentDate.HasValue)
                    {
                        TimeSpan rst = DateTime.Now.Subtract(acc.PurchaseOrder.LastPaymentDate.Value);
                        switch (acc.PurchaseOrder.Type)
                        {
                            case 1:
                                // ordenes de contado, se muestran solo las mayores a 30 dias                                                          
                                if (rst.Days > LapseSpotOrders)
                                    yield return acc;
                                break;
                            case 2:
                                if (rst.Days > CreditSpanOrders)
                                    yield return acc;
                                break;
                            default:
                                yield return acc;
                                break;
                        }
                    }
                }
            }           
        }

        public IEnumerable<Model.AfterSalesAccount> ToList(int provincia, int canton, int distrito, int diasinicio, int diasfin, string vendedor = "", int oportunidad = 0)
        {
            PortfolioAfterSales cartera = new PortfolioAfterSales(_gestor);
            //obtiene todas las cuentas postventa       
            asar.SetFilter(AfterSalesAccountRepository.FieldFilter.Province, provincia);
            asar.SetFilter(AfterSalesAccountRepository.FieldFilter.City, canton);
            asar.SetFilter(AfterSalesAccountRepository.FieldFilter.District, distrito);
            asar.SetFilter(AfterSalesAccountRepository.FieldFilter.StartDays, diasinicio);
            asar.SetFilter(AfterSalesAccountRepository.FieldFilter.EndDays, diasfin);
            asar.SetFilter(AfterSalesAccountRepository.FieldFilter.SalesMan, vendedor);
            asar.SetFilter(AfterSalesAccountRepository.FieldFilter.Opportunity, oportunidad);

            foreach (Model.AfterSalesAccount acc in asar.GetAllAccounts())
            {
                //Verifica si el vendedor existe en la cartera del vendedor
                if (cartera.Exist(acc.SalesMan.ToString()))
                {
                    //aplica las reglas de negocio y retorna solo los valores deseados
                    if (acc.PurchaseOrder.LastPaymentDate.HasValue)
                    {
                        TimeSpan rst = DateTime.Now.Subtract(acc.PurchaseOrder.LastPaymentDate.Value);
                        switch (acc.PurchaseOrder.Type)
                        {
                            case 1:
                                // ordenes de contado, se muestran solo las mayores a 30 dias                                                          
                                if (rst.Days > LapseSpotOrders)
                                    yield return acc;
                                break;
                            case 2:
                                if (rst.Days > CreditSpanOrders)
                                    yield return acc;
                                break;
                            default:
                                yield return acc;
                                break;
                        }
                    }
                }
            }
        }
    }
}

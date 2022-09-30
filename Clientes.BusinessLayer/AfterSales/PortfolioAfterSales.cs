using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AfterSales
{
    public class PortfolioAfterSales
    {
        private string _gestor;
        private Model.Portfolio _portfolio;

        public PortfolioAfterSales(string gestor)
        {
            Repositories.AdoRepositories.PortfolioAfterSalesRepository repo = new Repositories.AdoRepositories.PortfolioAfterSalesRepository();
            _portfolio = repo.GetPortFolio(gestor);

            if (_portfolio == null)
                throw new Exception("El gestor no tiene un cartera postventa definida");
        }
        public bool Exist(string SalesManName)
        {
            SalesManName = SalesManName.ToLower();
            _portfolio.CharStart = _portfolio.CharStart.ToLower();
            _portfolio.CharEnd = _portfolio.CharEnd.ToLower();

                if((int)(SalesManName[0]) >= (int)(_portfolio.CharStart[0]) 
                    && (int)(SalesManName[0]) <= (int)(_portfolio.CharEnd[0]) )
                    return true;
                else
                    return false;

        }
    }
}

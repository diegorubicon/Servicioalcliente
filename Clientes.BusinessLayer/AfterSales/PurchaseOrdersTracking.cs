using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AfterSales.Repositories.AdoRepositories;

namespace AfterSales
{
    public class PurchaseOrdersTracking
    {
        public List<Model.DisableTrackings> GetDisableTrackings()
        {
            DisableTrackingRepository repo = new DisableTrackingRepository();

            return repo.GetAll();
        }
        public void DisableTracking(string PurchaseOrderNumber, decimal LastArrangement, string Executive)
        {
            Model.DisableTrackings dt = new Model.DisableTrackings()
            {
                DisableBy = Executive,
                DisableTime = DateTime.Now,
                LastArrangement = LastArrangement,
                PurchaseOrderNumber = PurchaseOrderNumber,
            };
            DisableTrackingRepository repo = new DisableTrackingRepository();

            repo.Add(dt);

        }
        public int ReactivateTracking(string PurchaseOrderNumber)
        {
            //Obtiene el tracking deshabilitado de la orden
            DisableTrackingRepository repo = new DisableTrackingRepository();

            return ReactivateTracking(repo.GetByPurchaseOrder(PurchaseOrderNumber));
          
        }
        public int ReactivateTracking(Model.DisableTrackings DisabledTracking)
        {
            if (DisabledTracking == null)
                return 0 ;

            DisableTrackingRepository repo = new DisableTrackingRepository();
            //cambio el estado de la notas en estado D
            repo.UpdateAfterSaleNote(DisabledTracking.PurchaseOrderNumber);

            //cambia el estado del cierre del tracking a 4 anulado
            DisabledTracking.Status = 4;            
            return repo.Update(DisabledTracking);
        }

    }
}

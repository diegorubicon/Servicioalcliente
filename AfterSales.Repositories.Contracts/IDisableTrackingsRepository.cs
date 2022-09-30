using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AfterSales.Repositories.Contracts
{
    public interface IDisableTrackingsRepository
    {
        Model.DisableTrackings GetByPurchaseOrder(string PurchaseOrderNumber);
        List<Model.DisableTrackings> GetAll();

        void Add(Model.DisableTrackings newDisableTracking);

    }
}

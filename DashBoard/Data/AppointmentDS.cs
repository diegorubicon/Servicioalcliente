using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DashBoard.Data
{
    class AppointmentDS
    {
        private DataBaseDataContext db = null;

        public AppointmentDS(String ConnectionString)
        {
            db = new DataBaseDataContext(ConnectionString);
        }
        public IEnumerable<Appointment> GetRows()
        {
            var query = from app in db.Appointments
                        select app;
            return query;
        }
    }
}

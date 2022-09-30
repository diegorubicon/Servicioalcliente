using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DashBoard
{
    public class DashBoard:List<Appointment>
    {
        private Data.AppointmentDS _datasource = null;

        public DashBoard(String ConnectionString)
        {
            _datasource = new Data.AppointmentDS(ConnectionString);

            foreach (Appointment app in _datasource.GetRows())
            {
                this.Add(app);
            }
        }

    }
}

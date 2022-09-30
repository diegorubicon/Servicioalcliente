using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Actividades.Business
{
    public class Organizer
    {

        private Data.Actividades data;

        public Organizer(string cnnstr)
        {
            data = new Data.Actividades(cnnstr);

            foreach (Data.ActividadDTO act in data.ObtenerTodas())
            {

            }
        }


    }
}

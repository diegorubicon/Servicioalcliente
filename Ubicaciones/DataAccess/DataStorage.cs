using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ubicaciones.DataAccess
{
    public abstract class DataStorage
    {
        protected string ConnectionString {get; set;}       
       
        public abstract Ubicacion getUbicacion(int Provincia, int Canton, int Distrito);
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Academic.Business
{
    public class Capacitacion2 : Entities.c
    {   
        private DataAccess.cAd dao = null;      

        public Capacitacion2(string ConnectionString)
        {
            dao = new DataAccess.cAd(ConnectionString);
        }      
        public void Update()
        {          
            if (dao.Exist(cap => cap.id == this.id))
            {
                dao.Update(this);
            }
            else
            {
                dao.Insert(this);
            }
        }
     }
}

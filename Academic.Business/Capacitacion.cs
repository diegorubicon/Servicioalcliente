using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Academic.Business
{
    public class Capacitacion : Entities.Capacitacion
    {
        private string _cnnstr;

        private DataAccess.cAd dao = null;
        private DataAccess.CapacitacionAD obj = null;

        public Capacitacion(string ConnectionString)
        {
            _cnnstr = ConnectionString;

            dao = new DataAccess.cAd(ConnectionString);
        }
        public Capacitacion(string ConnectionString, Entities.Capacitacion cap)
        {
            this.Id = cap.Id;
            this.Descripcion = cap.Descripcion;
            this.Modulos = cap.Modulos;

            _cnnstr = ConnectionString;
            
            
        }
        public bool Load(decimal id)
        {
            using (DataAccess.CapacitacionAD objdao = new DataAccess.CapacitacionAD(_cnnstr))
            {
                return objdao.Fill(this, capacitacion => capacitacion.Id == id);
            }

        }
        public List<Entities.Capacitacion> ToList()
        {
            using (DataAccess.CapacitacionAD objdao = new DataAccess.CapacitacionAD(_cnnstr))
            {
                return objdao.LoadAll();
            }
        }
        public void Update()
        {
            using (DataAccess.CapacitacionAD objdao = new DataAccess.CapacitacionAD(_cnnstr))
            {
                if (objdao.Exist(cap => cap.Id == this.Id))
                {
                    objdao.Update(this);
                }
                else
                {
                    objdao.Insert(this);
                }
            }
            
        }
        public void Remove()
        {
            using (DataAccess.CapacitacionAD objdao = new DataAccess.CapacitacionAD(_cnnstr))
            {
                objdao.Delete(this);
            }
        }

        public void AddAsistente(Entities.Modulo m ,Entities.Asistente asis)
        {
            using (DataAccess.CapacitacionAD objdao = new DataAccess.CapacitacionAD(_cnnstr))
            {
                objdao.AddAsistente(this, m, asis);
            }

        }
        public void DeleteAsistente(Entities.Modulo m, Entities.Asistente asis)
        {
            using (DataAccess.CapacitacionAD objdao = new DataAccess.CapacitacionAD(_cnnstr))
            {
                objdao.DeleteAsistente(this, m, asis);
            }

        }
    }
}

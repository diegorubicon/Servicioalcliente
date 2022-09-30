using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EnvioSMS.Data;

namespace EnvioSMS.Business
{
    public class PhoneVirtual
    {
        private Data.MensajesAD datos;

        public PhoneVirtual (string ConnectionString)
        {
            datos = new MensajesAD(ConnectionString);

        }

        public void SendSMSandSave(SMS s)
        {
            datos.AddMensaje(s);
            try
            {
                datos.SaveToDataBase();
            }
            catch (Exception ex)
            {
                throw new Exception("Error guardando los datos " + ex.Message);
            }
        }

    }
}

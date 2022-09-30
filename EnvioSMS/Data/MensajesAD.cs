using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
namespace EnvioSMS.Data
{
   
    public class MensajesAD
    {
        private SourceDataContext db = null;

        public MensajesAD(string ConnectionString)
        {
            db = new SourceDataContext(ConnectionString);
        }

        public void AddMensaje(EnvioSMS.Business.SMS sms)
        {
            envio_SM mr = new envio_SM { mensaje = sms.texto, 
                                        estado = 0, 
                                        intentos = 0, 
                                        fecha_envio = sms.FechaEnvio, 
                                        hora_envio = sms.HoraEnvio, 
                                        creado_el = DateTime.Now };
  
            foreach (EnvioSMS.Business.Destinatario dest in sms.Destinatarios)
            {

              envio_SMS_persona p = new envio_SMS_persona                
                {
                    persona = dest.Nombre,
                    telefono = dest.Telefono,
                    estado = 0
                };
             
               mr.envio_SMS_personas.Add(p);

            }          

        }
        public int SaveToDataBase()
        {
            try
            {
                db.SubmitChanges();
                return 0;
            }
            catch (Exception ex)
            {
                return -1;
            }


        }


    }
}

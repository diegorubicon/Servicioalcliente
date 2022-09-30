using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SalesMansLibrary.Data
{
    public class SalesMan
    {
        private dbDataContext db; //Conexion con la base de datos
        /// <summary>
        /// Crea un nuevo objeto de acceso a datos, controla la informacion de la tabla vendedores
        /// </summary>
        /// <param name="ConnectrionString">Cadena de conexion a la base de datos </param>
        public SalesMan(String ConnectrionString)
        {
            db = new dbDataContext(ConnectrionString);
        }
        /// <summary>
        /// Consulta a la base de datos la informacion de un vendedor
        /// </summary>
        /// <param name="Key">codigo del vendedor que de desea obtener la informacion</param>
        /// <returns>las filas de la base de datos que son inguales a Key </returns>
        public IEnumerable <vendedor> GetRow(String Key)
        {
            try
            {
                var query = from _vendedor in db.vendedors
                            where _vendedor.Codigo == Key
                            select _vendedor;
                return query;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Key"></param>
        /// <param name="Periodo"></param>
        /// <returns></returns>
        public IEnumerable<vendedor> GetNuevosReclutas(String Key, int Periodo)
        {
             var query = db.spObtenerNuevosReclutasxEquipo(Key, Periodo);

            foreach (spObtenerNuevosReclutasxEquipoResult recluta in query)
            {
                vendedor _vendedor = GetRow(recluta.recluta).First ();
                _vendedor.Generacion = (int) recluta.generacion;
                yield return _vendedor;
            }            
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Key"></param>
        /// <param name="periodo"></param>
        /// <returns></returns>
        public IEnumerable<vendedor> GetVentasEquipo (String Key, decimal periodo, bool WithLider)
        {   
            Int32 generacion;

            if (WithLider)
                generacion = 0;
            else
                generacion = 1;

            var quey = db.sp_ObtenerVentasporEquipo(Key, periodo, generacion);

            foreach (sp_ObtenerVentasporEquipoResult recluta in quey)
            {
                vendedor _vendedor = GetRow(recluta.recluta).First();
                _vendedor.Generacion = (int)recluta.generacion;
                _vendedor.VentaMensual = (double) recluta.venta;
                yield return _vendedor;
            }
        }
        public void UpdateTables()
        {
            try
            {
                db.SubmitChanges();
            }
            catch (Exception ex)
            {
                
            }
        }
    }
}

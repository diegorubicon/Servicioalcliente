using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace AfterSales.Repositories.AdoRepositories
{
    public class DisableTrackingRepository : Contracts.IDisableTrackingsRepository
    {
        private string _cnnstr;
        public DisableTrackingRepository()
        {
            _cnnstr = ConnectionStringManager.Broker.GetFirstConnectionString();
        }
        public List<Model.DisableTrackings> GetAll()
        {
            List<Model.DisableTrackings> lst = new List<Model.DisableTrackings>();
            using (SqlConnection db = new SqlConnection(_cnnstr))
            {
                StringBuilder query = new StringBuilder();
                query.Append("SELECT fdp.consecutivo,fdp.factura,fdp.cons_cierre,fdp.ult_gestion,fdp.fecha,fdp.ejecutivo, ");
                query.Append("np.observacion, fe.cliente, c.nombre+' '+c.apellido_01+' '+c.apellido_02 as nom_cliente ");
                query.Append("FROM  facturas_postventa_deshabilitadas fdp, notas_postventa np, facturas_encabezado fe, clientes c ");
                query.Append("WHERE fdp.ult_gestion = np.gestion AND fdp.factura = fe.factura and fe.cliente = c.cliente and fdp.estado = 1 ");
                query.Append("ORDER BY fdp.fecha desc");
                using (SqlCommand cmd = new SqlCommand(query.ToString(),db))
                {
                    cmd.CommandType = System.Data.CommandType.Text;
                    db.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        lst.Add(Mapper(reader));
                    }
                    db.Close();
                }
            }
            return lst;
        }
        public Model.DisableTrackings GetByPurchaseOrder(String PurchaseOrderNumber)
        {
             using (SqlConnection db = new SqlConnection(_cnnstr))
            {
                StringBuilder query = new StringBuilder();
                query.Append("SELECT fdp.consecutivo,fdp.factura,fdp.cons_cierre,fdp.ult_gestion,fdp.fecha,fdp.ejecutivo, ");
                query.Append("np.observacion, fe.cliente, c.nombre+' '+c.apellido_01+' '+c.apellido_02 as nom_cliente ");
                query.Append("FROM  facturas_postventa_deshabilitadas fdp, notas_postventa np, facturas_encabezado fe, clientes c ");
                query.Append("WHERE fdp.ult_gestion = np.gestion AND fdp.factura = fe.factura and fe.cliente = c.cliente and fdp.estado = 1 and fdp.factura = @factura ");
                query.Append("ORDER BY fdp.fecha desc");
                using (SqlCommand cmd = new SqlCommand(query.ToString(), db))
                {
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.Parameters.AddWithValue("factura", PurchaseOrderNumber);
                    db.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        return Mapper(reader);
                    }
                    else
                   {
                       return null;
                    }                    
                }
            }            
        }
        public void Add(Model.DisableTrackings newDisableTracking)
        {
           int Cons;
            using (SqlConnection db = new SqlConnection(_cnnstr))
            {
                db.Open(); //Abre la conexion a la base de datos
                //Verifica si la orden ya se desactivo
                StringBuilder query = new StringBuilder();
                query.Append("SELECT ISNULL(max(cons_cierre),0) ");
                query.Append("FROM facturas_postventa_deshabilitadas ");
                query.Append("WHERE factura = @factura ");

                using (SqlCommand cmd = new SqlCommand(query.ToString(), db))
                {
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.Parameters.AddWithValue("factura", newDisableTracking.PurchaseOrderNumber);

                    Cons = (int ) cmd.ExecuteScalar();
                }
                
                //Inserta la factura en la tabla de ordenes deshabilitads
                StringBuilder InsertSql = new StringBuilder();
                InsertSql.Append("INSERT INTO facturas_postventa_deshabilitadas ");
                InsertSql.Append("([factura],[cons_cierre],[ult_gestion],[fecha],[ejecutivo],[estado]) ");
                InsertSql.Append("VALUES (@factura,@cierre,@gestion,@fecha,@ejecutivo,1) ");
                using (SqlCommand cmd = new SqlCommand(InsertSql.ToString(), db))
                {
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.Parameters.AddWithValue("factura", newDisableTracking.PurchaseOrderNumber);
                    cmd.Parameters.AddWithValue("cierre", Cons+1);
                    cmd.Parameters.AddWithValue("gestion", newDisableTracking.LastArrangement);
                    cmd.Parameters.AddWithValue("fecha", newDisableTracking.DisableTime);
                    cmd.Parameters.AddWithValue("ejecutivo", newDisableTracking.DisableBy);
                    
                    int rst = cmd.ExecuteNonQuery();
                   
                }
                //Actualiza la tabla facturas_encabezado
                StringBuilder updateSql = new StringBuilder();
                updateSql.Append("UPDATE facturas_encabezado ");
                updateSql.Append("SET postventa = 1 ");
                updateSql.Append("WHERE factura = @factura");
                using (SqlCommand cmd = new SqlCommand(updateSql.ToString(), db))
                {
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.Parameters.AddWithValue("factura", newDisableTracking.PurchaseOrderNumber);

                    int rst = cmd.ExecuteNonQuery();
                }
            }
        }
        public Model.DisableTrackings Mapper(SqlDataReader reader)
        {
            return new Model.DisableTrackings()
            {
                Sequent = Convert.ToDecimal(reader["consecutivo"]),
                PurchaseOrderNumber = reader["factura"].ToString(),
                ClosingSequent = Convert.ToDecimal(reader["cons_cierre"]),
                LastArrangement = Convert.ToDecimal(reader["ult_gestion"]),
                LastNote = reader["observacion"].ToString(),
                DisableBy = reader["ejecutivo"].ToString(),
                DisableTime = Convert.ToDateTime(reader["fecha"]),
                Customer = new Model.DisableTrackingCustomer()
                { 
                    Id = reader["cliente"].ToString(),
                    Nombre = reader["nom_cliente"].ToString()
                }
            };          
            
        }
        public int UpdateAfterSaleNote(string factura)
        {
            using (SqlConnection db = new SqlConnection(_cnnstr))
            {
                db.Open();

                StringBuilder query = new StringBuilder();
                query.Append("UPDATE notas_postventa ");
                query.Append("SET estado = 3 ");
                query.Append("WHERE factura = @factura and estado = 4");
                using (SqlCommand cmd = new SqlCommand(query.ToString(), db))
                {
                    cmd.CommandType = System.Data.CommandType.Text;                    
                    cmd.Parameters.AddWithValue("factura", factura);

                    return cmd.ExecuteNonQuery();
                }

            }

        }
        public int Update(Model.DisableTrackings uptracking)
        {
            using (SqlConnection db = new SqlConnection(_cnnstr))
            {
                db.Open(); //Abre la conexion a la base de datos
                StringBuilder InsertSql = new StringBuilder();
                InsertSql.Append("UPDATE facturas_postventa_deshabilitadas ");
                InsertSql.Append("SET factura = @factura,cons_cierre = @cierre,ult_gestion = @gestion,fecha = @fecha,ejecutivo=@ejecutivo,estado=@estado ");
                InsertSql.Append("WHERE consecutivo = @consec ");
                using (SqlCommand cmd = new SqlCommand(InsertSql.ToString(), db))
                {
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.Parameters.AddWithValue("consec", uptracking.Sequent);
                    cmd.Parameters.AddWithValue("factura", uptracking.PurchaseOrderNumber);
                    cmd.Parameters.AddWithValue("cierre", uptracking.ClosingSequent);
                    cmd.Parameters.AddWithValue("gestion", uptracking.LastArrangement);
                    cmd.Parameters.AddWithValue("fecha", uptracking.DisableTime);
                    cmd.Parameters.AddWithValue("ejecutivo", uptracking.DisableBy);
                    cmd.Parameters.AddWithValue("estado", uptracking.Status);

                   return cmd.ExecuteNonQuery();

                }

            }

        }
    }
}

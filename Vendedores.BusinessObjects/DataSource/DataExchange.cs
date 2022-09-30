using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace Vendedores.BusinessObjects.DataSource
{
    public class DataExchange
    {
        private string _cnnstr = "";        
        
        public DataExchange(string ConnectionString)
        {
            _cnnstr = ConnectionString;
        }    
        public Vendedor Get(string CodigoVendedor)
        {
            using (SqlConnection db = new SqlConnection(_cnnstr))
            {
                StringBuilder query = new StringBuilder();
                query.Append("SELECT * ");
                query.Append("FROM vendedores ");
                query.Append("WHERE vendedor = @codigo ");

                SqlCommand cmd = new SqlCommand(query.ToString(), db);
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("codigo", CodigoVendedor);

                try
                {
                    db.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        Vendedor v = new Vendedor();
                        Ubicaciones.DataAccess.SqlDataStorage ubidb = new Ubicaciones.DataAccess.SqlDataStorage(_cnnstr);

                        v.Id = reader["vendedor"].ToString();
                        v.Contrato =(decimal) reader["num_contrato"];
                        v.Identificacion = new Personas.Identificacion();
                        v.Identificacion.Id_tipo = (string)  reader["tipo_de_identificacion"];
                        v.Identificacion.Numero = reader["identificacion"].ToString();
                        v.Nombre = reader["nombre"].ToString();
                        v.PrimerApellido = reader["apellido_01"].ToString();
                        v.SegundoApellido = reader["apellido_02"].ToString();
                        v.Telefono01 = reader["telefono"].ToString();
                        v.Telefono02 = reader["telefono_02"].ToString();
                        v.Telefono03 = reader["telefono_03"].ToString();                      
                        v.Email = reader["correo"].ToString();
                        v.Fax = reader["fax"].ToString();
                        v.FechaIngreso = Convert.ToDateTime(reader["fecha_ingreso"]);

                        v.Direccion = ubidb.getUbicacion(Convert.ToInt32(reader["provincia"]),
                                                        Convert.ToInt32(reader["canton"]),
                                                        Convert.ToInt32(reader["distrito"]));
                        v.Direccion.Especifica = reader["descripcion"].ToString();
                        return v;
                    }
                    else
                    {
                        return null;
                    }                   
                }
                catch (Exception ex)
                {                    
                    return null;
                }
                finally
                {
                    db.Close();
                }
            }
        }

        public IEnumerable<Vendedor> SelectAll()
        {
              StringBuilder query = new StringBuilder();
              query.Append("SELECT * ");
              query.Append("FROM vendedores ");               
              query.Append("ORDER by apellido_01  ");

                using (DataIO ds = new DataIO(_cnnstr))
                {
                    SqlDataReader reader = ds.RetrieveReader(query.ToString());

                    while (reader.Read())
                    {
                        yield return ParseToVendedor(ref reader);
                    }
                }              
            
        }
        public IEnumerable<Vendedor> SelectWithSales()
        {

            StringBuilder query = new StringBuilder();
            query.Append("SELECT * ");
            query.Append("FROM vendedores ");
            query.Append("WHERE vendedor in (SELECT vendedor FROM facturas_encabezado WHERE estado <> 4 and year(fecha) ="+ DateTime.Now.Year.ToString() +") ");
            query.Append("ORDER by apellido_01  ");

            using (DataIO ds = new DataIO(_cnnstr))
            {
                SqlDataReader reader = ds.RetrieveReader(query.ToString());

                while (reader.Read())
                {
                    yield return ParseToVendedor(ref reader);
                }
            }              
        }
        public IEnumerable<Vendedor> SelectWithSales(int PeriodoInicio, int PeriodoCierre)
        {

            StringBuilder query = new StringBuilder();
            query.Append("SELECT DISTINCT * ");
            query.Append("FROM vendedores "); 
            query.Append("WHERE vendedor in (SELECT vendedor FROM facturas_encabezado WHERE estado <> 4 AND tipo < 3 AND cierre >="+ PeriodoInicio.ToString() +" AND cierre <= "+ PeriodoCierre.ToString()  +" ) ");
            query.Append("ORDER by apellido_01  ");

            using (DataIO ds = new DataIO(_cnnstr))
            {
                SqlDataReader reader = ds.RetrieveReader(query.ToString());

                while (reader.Read())
                {
                    yield return ParseToVendedor(ref reader);
                }
            }
        }
        public IEnumerable<Vendedor> SelectByPeriodIncome(int Period)
        {
            StringBuilder query = new StringBuilder();
            query.Append("SELECT * ");
            query.Append("FROM vendedores ");
            query.Append("WHERE cierre_ingreso ="+ Convert.ToString(Period));
            query.Append("ORDER by apellido_01  ");

            using (DataIO ds = new DataIO(_cnnstr))
            {
                SqlDataReader reader = ds.RetrieveReader(query.ToString());

                while (reader.Read())
                {
                    yield return ParseToVendedor(ref reader);
                }
            }       
        }

        public IEnumerable<Vendedor> SelectBySponsor(string SponsorCode)
        {
            StringBuilder query = new StringBuilder();
            query.Append("SELECT * ");
            query.Append("FROM vendedores ");
            query.Append("WHERE patrocinador = '" + SponsorCode +"'");
            query.Append("ORDER by apellido_01  ");

            using (DataIO ds = new DataIO(_cnnstr))
            {
                SqlDataReader reader = ds.RetrieveReader(query.ToString());

                while (reader.Read())
                {
                    yield return ParseToVendedor(ref reader);
                }
            }
        }

        private Vendedor ParseToVendedor(ref SqlDataReader reader)
        {
            Vendedor v = new Vendedor();
            Ubicaciones.DataAccess.SqlDataStorage ubidb = new Ubicaciones.DataAccess.SqlDataStorage(_cnnstr);

            v.Id = reader["vendedor"].ToString();
            v.Contrato = (int) reader["num_contrato"];            
            v.Identificacion.Id_tipo =(string) reader["tipo_de_identificacion"];
            v.Identificacion.Numero = reader["identificacion"].ToString();
            v.Nombre = reader["nombre"].ToString();
            v.PrimerApellido = reader["apellido_01"].ToString();
            v.SegundoApellido = reader["apellido_02"].ToString();
            v.Telefono01 = reader["telefono"].ToString();
            v.Telefono02 = reader["telefono_02"].ToString();
            v.Telefono03 = reader["telefono_03"].ToString();
            v.Email = reader["correo"].ToString();
            v.Fax = reader["fax"].ToString();
            v.Direccion = ubidb.getUbicacion((int)reader["provincia"], (int)reader["canton"], (int)reader["distrito"]);
            v.Direccion.Especifica = reader["direccion"].ToString();

            return v;
        }
    }
}

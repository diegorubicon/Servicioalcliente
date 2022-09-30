using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace Survey.DataAccess
{
    public class RespondentAD
    {
        private string _cnnstr;
        private SqlConnection db;

        public RespondentAD(string ConnectionString)
        {
            _cnnstr = ConnectionString;
            db = new SqlConnection(_cnnstr);
        }
        public RespondentAD(SqlConnection connection)
        {
            db = connection;
        }
        public int Load(Entities.Respondent Container, string IdCliente)
        {
           
                StringBuilder query = new StringBuilder();
                query.Append("SELECT c.cliente,c.nombre+' '+c.apellido_01+' '+c.apellido_02 as nomcli,c.telefono_01,c.telefono_02,c.telefono_03,c.telefono_04,c.provincia,c.canton,ca.descripcion,");
                query.Append("v.vendedor,v.nombre+' '+v.apellido_01+' '+v.apellido_02 as nomven ");
                query.Append("FROM clientes c, cantones ca, vendedores v ");
                query.Append("WHERE c.vendedor = v.vendedor and c.provincia = ca.provincia and c.canton = ca.canton ");
                query.Append("AND c.cliente = @cliente");
                using (SqlCommand cmd = new SqlCommand(query.ToString(),db))
                {
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.Parameters.AddWithValue("cliente", IdCliente);
                    try
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable Table = new DataTable();

                        adapter.Fill(Table);

                        foreach (DataRow r in Table.Rows)
                        {                           
                            Container.Poll = null;
                            Container.Agent = new Entities.Agent
                            {
                                Id = r["vendedor"].ToString(),
                                Nombre = r["nomven"].ToString()
                            };
                            Container.Id = r["cliente"].ToString();
                            Container.Nombre = r["nomcli"].ToString();
                            Container.Zone = new Entities.Zone
                            {
                                Id = (decimal)r["canton"],
                                Nombre = r["descripcion"].ToString()
                            };
                        }
                        return 1;

                    }
                    catch (Exception)
                    {
                        return -1;
                    }

              

            }
        }

        public int Insert(Survey.Entities.Respondent NewRespondent)
        {
        
                StringBuilder query = new StringBuilder();
                query.Append("INSERT INTO encuesta_clientes ");
                query.Append("(id_encuesta,id_cliente,encuestado_el) ");
                query.Append("VALUES(@encuesta,@cliente,getdate())");
                using (SqlCommand cmd = new SqlCommand(query.ToString(), db))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("encuesta", NewRespondent.Poll.Id);
                    cmd.Parameters.AddWithValue("cliente", NewRespondent.Id);
                    try
                    {
                        int rst = cmd.ExecuteNonQuery();

                        StringBuilder query2 = new StringBuilder();
                        query2.Append("INSERT INTO encuesta_clientes_preguntas ");
                        query2.Append("(id_encuesta,id_cliente,SatisfaccionProducto,SatisfaccionDistribuidor,SatisfaccionCompania,");
                        query2.Append("ConocimientoGarantias,conocimientouso,conocimientoNopega,conocimientonoahuma,conocimientohornea,");
                        query2.Append("conocimientonoprecalienta,proximavisita) ");
                        query2.Append("VALUES (@encuesta,@cliente,@satisfaccionproducto,@satisfacciondistribuidor,@satisfaccioncompania,");
                        query2.Append("@conocimientogarantias,@conocimientouso,@conocimientonopega,@conocimientonoahuma,@conocimientohornea,");
                        query2.Append("@conocimientoprecalienta,@proximavisita) ");

                        using (SqlCommand cmd2 = new SqlCommand(query2.ToString(), db))
                        {
                            cmd2.CommandType = CommandType.Text;
                            cmd2.Parameters.AddWithValue("encuesta", NewRespondent.Poll.Id);
                            cmd2.Parameters.AddWithValue("cliente", NewRespondent.Id);
                            cmd2.Parameters.AddWithValue("satisfaccionproducto", NewRespondent.Questions.Producto);
                            cmd2.Parameters.AddWithValue("satisfacciondistribuidor", NewRespondent.Questions.Distribuidor);
                            cmd2.Parameters.AddWithValue("satisfaccioncompania", NewRespondent.Questions.Empresa);
                            cmd2.Parameters.AddWithValue("conocimientogarantias", NewRespondent.Questions.Garantias);
                            cmd2.Parameters.AddWithValue("conocimientouso", NewRespondent.Questions.Uso);
                            cmd2.Parameters.AddWithValue("conocimientonopega", NewRespondent.Questions.No_Pega);
                            cmd2.Parameters.AddWithValue("conocimientonoahuma", NewRespondent.Questions.No_ahuma);
                            cmd2.Parameters.AddWithValue("conocimientohornea", NewRespondent.Questions.Hornea);
                            cmd2.Parameters.AddWithValue("conocimientoprecalienta", NewRespondent.Questions.No_Se_Precalienta);
                            cmd2.Parameters.AddWithValue("proximavisita", NewRespondent.Questions.Proxima_Visita);

                            int rst2 = cmd2.ExecuteNonQuery();
                        }


                        return rst;
                    }
                    catch (Exception)
                    {
                        return -1; 
                    }
             
            }
        }
        public bool Exist(Survey.Entities.Respondent NewRespondent)
        {
            StringBuilder query = new StringBuilder();
            query.Append("SELECT CAST(ISNULL(COUNT(*),0) AS int) ");
            query.Append("FROM encuesta_clientes ");
            query.Append("WHERE id_encuesta = @encuesta and id_cliente = @cliente");
            using (SqlCommand cmd = new SqlCommand(query.ToString(),db))
            {
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("encuesta", NewRespondent.Poll.Id);
                cmd.Parameters.AddWithValue("cliente", NewRespondent.Id);
                try
                {
                    Int32 rst =  (Int32) cmd.ExecuteScalar();
                    if (rst <= 0)
                        return false;
                    else
                        return true;

                }
                catch (Exception)
                {
                    return false; 
                }
            }

        }
        public void Update(Survey.Entities.Respondent NewRespondent)
        {
            

        }
    }
}

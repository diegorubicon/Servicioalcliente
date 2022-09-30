using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;


namespace Survey.DataAccess
{
    public class PollAD
    {
        private string _cnnstr;

        public PollAD(string ConnectionString)
        {
            _cnnstr = ConnectionString;
        }
        public bool Exist(int mes, int periodo)
        {
            using (SqlConnection db = new SqlConnection(_cnnstr))
            {
                StringBuilder query = new StringBuilder();
                query.Append("SELECT isnull(COUNT(id_encuesta),0) ");
                query.Append("FROM encuestas ");
                query.Append("WHERE mes = @mes AND periodo = @periodo");
                using (SqlCommand cmd = new SqlCommand(query.ToString(), db))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("mes", mes);
                    cmd.Parameters.AddWithValue("periodo", periodo);
                    try
                    {
                        int rst =(int) cmd.ExecuteScalar();
                        if (rst == 1)
                            return true;
                        else
                            return false;
                    }
                    catch (Exception)
                    {
                        return false;
                    }

                }
            }
        }
        public bool Exist(Survey.Entities.Poll p)
        {
            using (SqlConnection db = new SqlConnection(_cnnstr))
            {
                StringBuilder query = new StringBuilder();
                query.Append("SELECT isnull(COUNT(id),0) ");
                query.Append("FROM encuestas ");
                query.Append("WHERE id = @encuesta");
                using (SqlCommand cmd = new SqlCommand(query.ToString(), db))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("encuesta", p.Id);                    
                    try
                    {
                        db.Open();
                        int rst = (int)cmd.ExecuteScalar();
                        db.Close();
                        if (rst == 1)
                            return true;
                        else
                            return false;
                    }
                    catch (Exception)
                    {
                        return false;
                    }

                }
            }
        }
        public int Insert(Survey.Entities.Poll NewPoll)
        {
            using (SqlConnection db = new SqlConnection(_cnnstr))
            {
                using (SqlCommand cmd = new SqlCommand("[sac.Survey].InsertPoll", db))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("mes", NewPoll.Mes);
                    cmd.Parameters.AddWithValue("periodo", NewPoll.Periodo);
                    cmd.Parameters.AddWithValue("descripcion", NewPoll.Descripcion);
                    try
                    {
                        db.Open();
                        NewPoll.Id = (decimal) cmd.ExecuteScalar();                       
                        foreach (Survey.Entities.Respondent res in NewPoll.Respondents)
                        {
                            RespondentAD resAD = new RespondentAD(db);
                            resAD.Insert(res);
                         }
                         db.Close();
                         return 1;
                    }
                    catch (Exception)
                    {
                        return -1;
                    }
                }
            }
        }
        public int Update(Survey.Entities.Poll NewPoll)
        {
            using (SqlConnection db = new SqlConnection(_cnnstr))
            {
                StringBuilder query = new StringBuilder();
                query.Append("UPDATE encuestas ");
                query.Append("SET mes = @mes, periodo = @periodo,descripcion = @descripcion ");
                query.Append("WHERE id = @id");
                using (SqlCommand cmd = new SqlCommand(query.ToString(),db))
                {
                    cmd.CommandType =  System.Data.CommandType.Text;
                    cmd.Parameters.AddWithValue("id", NewPoll.Id);
                    cmd.Parameters.AddWithValue("mes", NewPoll.Mes);
                    cmd.Parameters.AddWithValue("periodo", NewPoll.Periodo);
                    cmd.Parameters.AddWithValue("descripcion", NewPoll.Descripcion);
                    try
                    {
                        db.Open();
                        int rst = cmd.ExecuteNonQuery();
                       

                        foreach (Survey.Entities.Respondent resp in NewPoll.Respondents)
                        {
                            RespondentAD resAD = new RespondentAD(db);
                            if (resAD.Exist(resp))
                                resAD.Update(resp);
                            else
                                resAD.Insert(resp);
                        }
                        db.Close();
                        return 1;
                    }
                    catch (Exception)
                    {
                        return -1;
                    }
                }
            }
        }
        public int Fill(Survey.Entities.Poll Container, int mes , int periodo)
        {            
            using (SqlConnection db = new SqlConnection(_cnnstr))
            {
                StringBuilder query = new StringBuilder();
                query.Append("SELECT TOP 1 * ");
                query.Append("FROM Encuestas ");
                query.Append("WHERE mes = @mes and periodo = @periodo");
                //Comando que obtiene los datos
                using (SqlCommand cmd = new SqlCommand(query.ToString(),db))
                {                    
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.Parameters.AddWithValue("mes", mes);
                    cmd.Parameters.AddWithValue("periodo", periodo);
                    try
                    {
                        db.Open(); //Abre la conexion con la base de datos
                        SqlDataAdapter Adapter = new SqlDataAdapter(cmd);
                        DataTable Table = new DataTable("Encuestas");                        
                        Adapter.Fill(Table);
                        if (Table.Rows.Count > 0)
                        {
                            DataRow row = Table.Rows[0];
                           
                            Container.Id = (decimal) row["id"];
                            Container.Mes = (int)row["mes"];
                            Container.Periodo = (int)row["periodo"];
                            Container.Descripcion = (string) row["descripcion"];
                            Container.Respondents = new List<Entities.Respondent>();
                            
                            query = new StringBuilder();
                            query.Append("SELECT ec.id_cliente,c.nombre+' '+c.apellido_01+' '+c.apellido_02 as nomcli,c.telefono_01,c.telefono_02,c.telefono_03,c.telefono_04,c.provincia,c.canton,ca.descripcion,") ;
                            query.Append("v.vendedor,v.nombre+' '+v.apellido_01+' '+v.apellido_02 as nomven ");
                            query.Append("FROM encuesta_clientes ec,clientes c, cantones ca, vendedores v ");
                            query.Append("WHERE ec.id_cliente = c.cliente and c.vendedor = v.vendedor and c.provincia = ca.provincia and c.canton = ca.canton ");
                            query.Append("and ec.id_encuesta = @encuesta");
                            
                            using (SqlCommand cmd2 = new SqlCommand(query.ToString(),db))
                            {
                                cmd2.CommandType = CommandType.Text;
                                cmd2.Parameters.AddWithValue("encuesta", Container.Id);

                                SqlDataAdapter adapter2 = new SqlDataAdapter(cmd2);
                                DataTable Table2 = new DataTable();

                                adapter2.Fill(Table2);

                                foreach (DataRow r in Table2.Rows)
                                {
                                    Entities.Respondent resp = new Entities.Respondent();
                                    resp.Poll = Container;
                                    resp.Agent = new Entities.Agent
                                    {
                                        Id = r["vendedor"].ToString(),
                                        Nombre = r["nomven"].ToString()
                                    };
                                    resp.Id = r["id_cliente"].ToString();
                                    resp.Nombre = r["nomcli"].ToString();
                                    resp.Zone = new Entities.Zone
                                    {
                                        Id = (decimal)r["canton"],
                                        Nombre = r["descripcion"].ToString()
                                    };
                                    Container.Respondents.Add(resp);
                                }
                            }
                            return 1;
                        }
                        else
                        {
                            Container = null;
                            return 0;
                        }
                    }
                    catch (Exception)
                    {
                        return -1;
                    }
                }
             }
        }
        public int Fill(Survey.Entities.Poll Container)
        {
            using (SqlConnection db = new SqlConnection(_cnnstr))
            {
                StringBuilder query = new StringBuilder();
                query.Append("SELECT TOP 1 * ");
                query.Append("FROM Encuestas ");
                query.Append("ORDER BY id ASC");
                //Comando que obtiene los datos
                using (SqlCommand cmd = new SqlCommand(query.ToString(), db))
                {
                    cmd.CommandType = System.Data.CommandType.Text;                   
                    try
                    {
                        db.Open(); //Abre la conexion con la base de datos
                        SqlDataAdapter Adapter = new SqlDataAdapter(cmd);
                        DataTable Table = new DataTable("Encuestas");
                        Adapter.Fill(Table);
                        if (Table.Rows.Count > 0)
                        {
                            DataRow row = Table.Rows[0];

                            Container.Id = (decimal)row["id"];
                            Container.Mes = (int)row["mes"];
                            Container.Periodo = (int)row["periodo"];
                            Container.Descripcion = (string)row["descripcion"];
                            Container.Respondents = new List<Entities.Respondent>();

                            query = new StringBuilder();
                            query.Append("SELECT ec.id_cliente,c.nombre+' '+c.apellido_01+' '+c.apellido_02 as nomcli,c.telefono_01,c.telefono_02,c.telefono_03,c.telefono_04,c.provincia,c.canton,ca.descripcion,");
                            query.Append("v.vendedor,v.nombre+' '+v.apellido_01+' '+v.apellido_02 as nomven ");
                            query.Append("FROM encuesta_clientes ec,clientes c, cantones ca, vendedores v ");
                            query.Append("WHERE ec.id_cliente = c.cliente and c.vendedor = v.vendedor and c.provincia = ca.provincia and c.canton = ca.canton ");
                            query.Append("and ec.id_encuesta = @encuesta");

                            using (SqlCommand cmd2 = new SqlCommand(query.ToString(), db))
                            {
                                cmd2.CommandType = CommandType.Text;
                                cmd2.Parameters.AddWithValue("encuesta", Container.Id);

                                SqlDataAdapter adapter2 = new SqlDataAdapter(cmd2);
                                DataTable Table2 = new DataTable();

                                adapter2.Fill(Table2);

                                foreach (DataRow r in Table2.Rows)
                                {
                                    Entities.Respondent resp = new Entities.Respondent();
                                    resp.Poll = Container;
                                    resp.Agent = new Entities.Agent
                                    {
                                        Id = r["vendedor"].ToString(),
                                        Nombre = r["nomven"].ToString()
                                    };
                                    resp.Id = r["id_cliente"].ToString();
                                    resp.Nombre = r["nomcli"].ToString();
                                    resp.Zone = new Entities.Zone
                                    {
                                        Id = (decimal)r["canton"],
                                        Nombre = r["descripcion"].ToString()
                                    };
                                    Container.Respondents.Add(resp);
                                }
                            }
                            return 1;
                        }
                        else
                        {
                            Container = null;
                            return 0;
                        }
                    }
                    catch (Exception)
                    {
                        return -1;
                    }
                }
            }
        }
    }
}

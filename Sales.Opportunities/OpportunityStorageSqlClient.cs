using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using TerritorialDivisionLib;

namespace Sales.Opportunities
{
    public class OpportunityStorageSqlClient
    {
        private string _cnnstr;

        public OpportunityStorageSqlClient(string ConnectionString)
        {
            _cnnstr = ConnectionString;
            if (_cnnstr[_cnnstr.Length-1] != ';')
                _cnnstr += ";";

            _cnnstr += "MultipleActiveResultSets=True";

        }
        public void Fill(List<SalesOpportunity> lst)
        {

        }
        public void Fill(List<SalesOpportunity> lst, string AssignedDealer)
        {
            using (SqlConnection db = new SqlConnection(_cnnstr))
            {
                StringBuilder query = new StringBuilder();
                query.Append("SELECT * ");
                query.Append("FROM oportunidades o ");
                query.Append("WHERE o.distribuidor = @distribuidor ");

                SqlCommand cmd = new SqlCommand(query.ToString(), db);
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("distribuidor", AssignedDealer);
                try
                {
                    db.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        SalesOpportunity op = new SalesOpportunity();
                        Provinces provinciaad = new Provinces();


                        op.Id = reader["id"].ToString();
                        op.identificacion = reader["identificacion"].ToString();

                        //op.Provincia = provinciaad[(int)reader["provincia"]];
                        //op.Canton = op.Provincia.Cantons[(int)reader["canton"]];

                        //op.Distrito = op.Canton.Districts[(int)reader["distrito"]];


                        op.direccion = reader["direccion"].ToString();
                        op.DistribuidorAsignado = AssignedDealer;

                        StringBuilder query2 = new StringBuilder();
                        query2.Append("SELECT * ");
                        query2.Append("FROM  [pre-contactos] ");
                        query2.Append("WHERE id = @precontacto ");

                        SqlCommand cmdcont = new SqlCommand(query2.ToString(), db);
                        cmdcont.CommandType = System.Data.CommandType.Text;
                        cmdcont.Parameters.AddWithValue("precontacto", reader["id_precontacto"]);

                        SqlDataReader reader2 = cmdcont.ExecuteReader();
                        if (reader2.Read())
                        {
                            op.Contact = new Contact
                            {
                                Id = reader2["id"].ToString(),
                                Nombre = reader2["nombre"].ToString(),
                                Apellido01 = reader2["apellido_01"].ToString(),
                                Apellido02 = reader2["apellido_02"].ToString(),
                                Telefono01 = reader2["telefono_01"].ToString(),
                                Telefono02 = reader2["telefono_02"].ToString(),
                                Email = reader2["email"].ToString()
                            };
                        }
                        lst.Add(op);
                    }
                    db.Close();
                }
                catch (Exception ex)
                {

                }

            }
        }
    }
}

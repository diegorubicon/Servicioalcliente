using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace AfterSales.Repositories.AdoRepositories
{
    public class PortfolioAfterSalesRepository
    {
        private string _cnnstr;

        public PortfolioAfterSalesRepository()
        {
            _cnnstr = ConnectionStringManager.Broker.GetConnectionString("SakifConn");
        }
        public Model.Portfolio GetPortFolio(string gestor)
        {
            StringBuilder query = new System.Text.StringBuilder();

            query.Append("SELECT letra_inicio, letra_fin ");
            query.Append("FROM carteras_postventa ");
            query.Append("WHERE usuario = @usuario");

            using (SqlConnection db = new SqlConnection(_cnnstr))
            {
                using (SqlCommand cmd1 = new SqlCommand(query.ToString(), db))
                {
                    cmd1.CommandType = System.Data.CommandType.Text;
                    cmd1.Parameters.AddWithValue("@usuario", gestor);
                    db.Open();
                    Model.Portfolio port = null;
                    SqlDataReader reader = cmd1.ExecuteReader();
                    if (reader.Read())
                        port = new Model.Portfolio()
                        {
                            CharStart = reader["letra_inicio"].ToString(),
                            CharEnd = reader["letra_fin"].ToString()
                        };
                    db.Close();
                    return port;
                }
            }
        }
    }
}

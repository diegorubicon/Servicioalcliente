using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace FollowUp.DataAccess
{
    public class ListStorage
    {
        private string _cnnstr;

        public ListStorage(string ConnectionString)
        {
            _cnnstr = ConnectionString;
        }
        public void Fill(Entities.Lists lst)
        {
            using (SqlConnection db = new SqlConnection(_cnnstr))
            {
                StringBuilder query = new StringBuilder();
                query.Append("SELECT * ");
                query.Append("FROM listas ");

                SqlCommand cmd = new SqlCommand(query.ToString(), db);
                cmd.CommandType = System.Data.CommandType.Text;


                db.Open();
                SqlDataReader Reader = cmd.ExecuteReader();
                while (Reader.Read())
                {
                    Entities.List l = new Entities.List
                    {
                        Id = Reader["lista"].ToString(),
                        Name = Reader["descripcion"].ToString(),
                        Description = ""
                    };
                    lst.Add(l);
                }
            }
        }
    }
}

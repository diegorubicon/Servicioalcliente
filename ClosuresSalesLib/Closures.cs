using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace ClosuresSalesLib
{
    public class Closures
    {
        private SqlConnection _cnn = null;
        private Closure _last = null;
        public Closures(SqlConnection Conn)
        {
            _cnn = Conn;
        }
        public Closure Last
        {
            get
            {
                if (_last == null)
                {
                    //Obtiene el ultimo cierre
                    StringBuilder str = new StringBuilder();
                    str.Append("select isnull(max(cod_cierre),0)+1 as cierre,max(fecha_cierre) as fecha ");
                    str.Append("from cierres_bonos");

                    SqlCommand cmd = new SqlCommand(str.ToString(), _cnn);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        DataRow row = dt.Rows[0];
                        _last =  new Closure()
                        {
                            Id = Convert.ToDecimal(row["cierre"]),
                            FechaInicio = Convert.ToDateTime(row["fecha"]),
                            FechaCierre = Convert.ToDateTime(row["fecha"])
                        };
                    }
                    else
                    {
                        _last = new Closure()
                        {
                            Id = 1,
                            FechaInicio = DateTime.Now,
                            FechaCierre = DateTime.Now
                        };
                    }
                }
                return _last;
            }
        }
    }
}

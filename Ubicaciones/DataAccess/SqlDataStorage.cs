using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using DataManager;

namespace Ubicaciones.DataAccess
{
    public class SqlDataStorage : DataStorage
    {
        public SqlDataStorage(string ConnectionString)
        {
            
            this.ConnectionString = ConnectionString;

            if (this.ConnectionString.Contains("MultipleActiveResultSets"))
                return;

            //Habilita que la cadena de conexion pueda devolver multiples readers
            if (this.ConnectionString[this.ConnectionString.Length - 1] != ';')
                this.ConnectionString += ";";

            this.ConnectionString += "MultipleActiveResultSets=True";
        }

        public override Ubicacion getUbicacion(int provincia, int canton, int distrito)
        {
            using (SqlDataFunctions data = new SqlDataFunctions(this.ConnectionString))
            {
                data.TableName = "provincias";
                data.SetFiltro("provincia", Signos.Igual, provincia);

                SqlDataReader reader = data.RetrieveData();

                if (reader.Read())
                {
                    Ubicacion RecoveryLocation = new Ubicacion();
                    RecoveryLocation.Provincia.Id = Convert.ToInt32(reader["provincia"]);
                    RecoveryLocation.Provincia.Nombre = reader["descripcion"].ToString();


                    data.TableName = "Cantones";
                    data.SetFiltro("provincia",Signos.Igual,provincia);
                    data.SetFiltro("canton", Signos.Igual, canton);
                    SqlDataReader reader2 = data.RetrieveData();

                    if (reader2.Read())
                    {
                        RecoveryLocation.Provincia.Canton.Id = Convert.ToInt32(reader2["canton"]);
                        RecoveryLocation.Provincia.Canton.Nombre = reader2["descripcion"].ToString();

                        data.TableName = "Distritos";
                        data.SetFiltro("provincia",Signos.Igual,provincia);
                        data.SetFiltro("canton", Signos.Igual, canton);
                        data.SetFiltro("distrito",Signos.Igual,distrito);

                        SqlDataReader reader3 = data.RetrieveData();

                        if (reader3.Read())
                        {
                            RecoveryLocation.Provincia.Canton.Distrito.Id= Convert.ToInt32(reader3["distrito"]);
                            RecoveryLocation.Provincia.Canton.Distrito.Nombre = reader3["descripcion"].ToString();
                        }
                    }

                    return RecoveryLocation;

                }else
                {
                    return null;
                }
            }
        }
    }
}

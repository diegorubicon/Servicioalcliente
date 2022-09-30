using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;


namespace AfterSales.Repositories.AdoRepositories
{
    public class AfterSalesAccountRepository
    {
        private string _cnnstr;
        private object _province,_city,_district;
        private int _startdays, _enddays;
        private string _vendedor;
        private int _opportunity;


        public enum FieldFilter
        {
            Province,City,District,StartDays,EndDays, SalesMan, Opportunity
        }
        public AfterSalesAccountRepository()
        {
            try
            {
                _cnnstr = ConnectionStringManager.Broker.GetConnectionString("SakifConn");
                _province = 0;
                _city = 0;
                _district = 0;
                _startdays = 0;
                _enddays = int.MaxValue;
                _vendedor = "";
                _opportunity = 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Error obteniendo la cadena de conexion "+ex.InnerException.Message);
            }
        }
        public void SetFilter(FieldFilter Field, object value)
        {
            if (Field == FieldFilter.Province)
                _province = value;
            if (Field == FieldFilter.City)
                _city = value;
            if (Field == FieldFilter.District)
                _district = value;
            if (Field == FieldFilter.StartDays)
                _startdays = (int)value;
            if (Field == FieldFilter.EndDays)
                _enddays = (int)value;
            if (Field == FieldFilter.SalesMan)
                _vendedor = (string)value;
            if (Field == FieldFilter.Opportunity)
                _opportunity = (int)value;

        }

        
      
        public IEnumerable<Model.AfterSalesAccount> GetAllAccounts()
        {
            using (SqlConnection db = new SqlConnection(_cnnstr))
            {
                using (SqlCommand cmd = new SqlCommand("GetAfterSalesAccount2",db))   
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("provincia", _province);
                    cmd.Parameters.AddWithValue("canton", _city);
                    cmd.Parameters.AddWithValue("distrito", _district);
                    cmd.Parameters.AddWithValue("diasinicio", _startdays);
                    cmd.Parameters.AddWithValue("diasfin", _enddays);
                    cmd.Parameters.AddWithValue("vendedor", _vendedor);
                    cmd.Parameters.AddWithValue("oportunidad", _opportunity);
                    cmd.CommandTimeout = 360;
                    db.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    int cont = 0;
                    while (reader.Read())
                    {
                        Model.AfterSalesAccount rst= Mapper(reader);
                        
                        /*SqlCommand cmd2 = new SqlCommand("GetAfterSalesLastCall",db);
                        cmd2.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd2.Parameters.AddWithValue("factura", rst.PurchaseOrder.Number);
                        
                        SqlDataReader reader2 = cmd2.ExecuteReader();
                        if (reader2.Read())
                        {
                            rst.NextCallDate = Convert.ToDateTime(reader2["fecha_proxima_llamada"]);
                            rst.LastManager = reader2["creado_por"].ToString();
                            
                            if (reader2["estado"].ToString() == "1") 
                                rst.LastCallStatus = "A";
                        
                            if (reader2["estado"].ToString() == "2")
                                rst.LastCallStatus = "B";

                            if (reader2["estado"].ToString() == "3")
                                rst.LastCallStatus = "C";
                        
                        }
                        reader2.Close();*/
                        cont++;
                        yield return rst;
                    }

                    reader.Close();
                    db.Close();
                }
            }
        }
        private Model.AfterSalesAccount Mapper(SqlDataReader r)
        {
            Model.AfterSalesAccount asa = new Model.AfterSalesAccount();

            asa.PurchaseOrder.Number = r["factura"].ToString();
            asa.PurchaseOrder.DateOfAdmission = Convert.ToDateTime(r["fecha"]);
            asa.PurchaseOrder.Type = Convert.ToInt32(r["tipo"]);
            if (r["ultpago"] == DBNull.Value)
            {
                asa.PurchaseOrder.LastPaymentDate = null;                
            }else
            {
                asa.PurchaseOrder.LastPaymentDate = Convert.ToDateTime(r["ultpago"]);
            }

            if (!(r["fecha_proxima_llamada"] == System.DBNull.Value))
                asa.NextCallDate = Convert.ToDateTime(r["fecha_proxima_llamada"]);

            asa.LastManager = (r["gestor"] == System.DBNull.Value) ? "" : r["gestor"].ToString();

            if (r["estado"].ToString() == "1")
                asa.LastCallStatus = "A";

            if (r["estado"].ToString() == "2")
                asa.LastCallStatus = "B";

            if (r["estado"].ToString() == "3")
                asa.LastCallStatus = "C";

            if (r["fecha_oportunidad"] == DBNull.Value)
            {
                asa.OpportunityDate = null;
            }
            else
            {
                asa.OpportunityDate = Convert.ToDateTime(r["fecha_oportunidad"]);
            }

            asa.Customer.Id = r["cliente"].ToString();
            asa.Customer.Name = r["cnombre"].ToString();
            asa.Customer.FirstName = r["capellido01"].ToString();
            asa.Customer.LastName = r["capellido02"].ToString();
            asa.Customer.Interes.Id = (r["interespostventa"] == System.DBNull.Value) ? "" : r["interespostventa"].ToString();
            asa.Customer.Interes.Name = (r["descripcion"] == System.DBNull.Value) ? "" : r["descripcion"].ToString();
            asa.Customer.CreditLevel = (r["tipo_cliente"] == System.DBNull.Value) ? "" : r["tipo_cliente"].ToString();
            asa.Customer.Province = r["provincia"].ToString();
            asa.Customer.City = r["canton"].ToString();
            asa.Customer.HomePhoneNumber = r["ctelefono01"].ToString();
            asa.Customer.CellPhoneNumber = r["ctelefono02"].ToString();

            asa.SalesMan.Id = r["vendedor"].ToString();
            asa.SalesMan.Name = r["vnombre"].ToString();
            asa.SalesMan.FirstName = r["vapellido01"].ToString();
            asa.SalesMan.LastName = r["vapellido02"].ToString();

            return asa;
        }
    }
}

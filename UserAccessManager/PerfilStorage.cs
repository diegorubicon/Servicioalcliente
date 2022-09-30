using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;


namespace UserAccessManager
{
    public class PerfilStorage
    {
        private string _cnnstr = "";
        private string TableSource = "perfiles_sc";
        private string PrimaryKey = "id";

        public PerfilStorage(string ConnectionString)
        {
            _cnnstr = ConnectionString;
        }
        public IEnumerable<Perfil> LoadAll()
        {
            using (SqlConnection db = new SqlConnection(_cnnstr))            
            {
                StringBuilder query = new StringBuilder();
                query.Append("SELECT psc.nombre,psc.descripcion,ap.* ");
                query.Append("FROM perfiles_sc psc, accesos_perfil ap ");
                query.Append("WHERE psc.id = ap.cod_perfil ");
                query.Append("ORDER BY nombre ASC ");

                SqlCommand cmd = new SqlCommand(query.ToString(), db);
                cmd.CommandType = System.Data.CommandType.Text;

             
                db.Open();
                SqlDataReader Reader = cmd.ExecuteReader();
                while (Reader.Read())
                {
                    Perfil retrieveperfil = new Perfil
                    {
                        Id = (decimal)Reader["cod_perfil"],
                        Descripcion = Reader["descripcion"].ToString(),
                        Nombre = Reader["nombre"].ToString()                       
                    };
                    retrieveperfil.Opciones.Clientes.BuscarCliente = (Reader["buscar_cliente"].ToString() == "1") ? true : false;
                    retrieveperfil.Opciones.Clientes.ActualizarDatos = (Reader["actualizar_datos_cliente"].ToString()== "1") ? true : false;
                    retrieveperfil.Opciones.Clientes.InformacionGeneral = (Reader["informacion_general_cliente"].ToString() == "1") ? true : false;
                    retrieveperfil.Opciones.Clientes.Facturacion =  (Reader["facturacion"].ToString() == "1") ? true : false;
                    retrieveperfil.Opciones.Clientes.Garantias = (Reader["garantias"].ToString() == "1") ? true : false;

                    retrieveperfil.Opciones.Vendedores.HistoricoCierres = (Reader["historico_cierres"].ToString() == "1") ? true : false;
                    retrieveperfil.Opciones.Vendedores.NiveldelVendedor = (Reader["nivel_vendedor"].ToString() == "1") ? true : false;
                    retrieveperfil.Opciones.Vendedores.InformacionPersonal = (Reader["informacion_general_vendedor"].ToString() == "1") ? true : false;
                    retrieveperfil.Opciones.Vendedores.ActualizarDatos = (Reader["actualizar_datos_vendedor"].ToString() == "1") ? true : false;
                    retrieveperfil.Opciones.Vendedores.Organizacion = (Reader["organizacion"].ToString() == "1") ? true : false;
                    retrieveperfil.Opciones.Vendedores.Referencia = (Reader["referencias"].ToString() == "1") ? true : false;

                    retrieveperfil.Opciones.Vendedores.Ventas.VentasPersonales = (Reader["ventas_personales"].ToString() == "1") ? true : false;
                    retrieveperfil.Opciones.Vendedores.Ventas.Resumen= (Reader["resumen"].ToString() == "1") ? true : false;
                    retrieveperfil.Opciones.Vendedores.Ventas.VentasUnidad = (Reader["ventas_unidad"].ToString() == "1") ? true : false;
                    retrieveperfil.Opciones.Vendedores.Ventas.DetalleVentasUnidad = (Reader["ventas_unidad_detalle"].ToString() == "1") ? true : false;
                    retrieveperfil.Opciones.Vendedores.Ventas.EstadoReclutamiento = (Reader["estado_reclutamiento"].ToString() == "1") ? true : false;
                    retrieveperfil.Opciones.Vendedores.Ventas.GraficoProvincias = (Reader["graficos_provincias"].ToString() == "1") ? true : false;

                    yield return retrieveperfil;
                }
                db.Close();               
            }
        }

        public void Add(ref Perfil p)
        {
            using (SqlConnection db = new SqlConnection(_cnnstr))
            {
                StringBuilder query = new StringBuilder();
                query.Append("SELECT isnull(max("+ PrimaryKey +"),0)+ 1 as nid ");
                query.Append("FROM "+TableSource);

                SqlCommand cmd = new SqlCommand(query.ToString(), db);
                try
                {
                    db.Open();
                    p.Id = (decimal)cmd.ExecuteScalar();

                    StringBuilder insert = new StringBuilder();
                    insert.Append("INSERT INTO perfiles_sc (id,nombre,descripcion) ");
                    insert.Append("VALUES(@id,@nombre,@descripcion)");

                    SqlCommand cmd2 = new SqlCommand(insert.ToString(), db);
                    cmd2.Parameters.AddWithValue("id", p.Id);
                    cmd2.Parameters.AddWithValue("nombre", p.Nombre);
                    cmd2.Parameters.AddWithValue("descripcion", p.Descripcion);

                    int rst = cmd2.ExecuteNonQuery();

                    StringBuilder detalle = new StringBuilder();
                    detalle.Append("INSERT INTO accesos_perfil ");
                    detalle.Append("([cod_perfil],[buscar_cliente],[informacion_general_cliente],[actualizar_datos_cliente],[facturacion],[garantias],[historico_cierres],[nivel_vendedor],[informacion_general_vendedor],[actualizar_datos_vendedor],[referencias],[organizacion],[resumen],[ventas_personales],[ventas_unidad],[ventas_unidad_detalle],[estado_reclutamiento],[graficos_provincias]) ");
                    detalle.Append("VALUES (@cd,@bc,@igc,@adc,@f,@g,@hc,@nv,@igv,@adv,@r,@o,@re,@vp,@vu,@vud,@er,@gp)");

                    SqlCommand cmd3 = new SqlCommand(detalle.ToString(), db);
                    cmd3.Parameters.AddWithValue("cd", p.Id);
                    cmd3.Parameters.AddWithValue("bc", p.Opciones.Clientes.BuscarCliente);
                    cmd3.Parameters.AddWithValue("igc", p.Opciones.Clientes.InformacionGeneral);
                    cmd3.Parameters.AddWithValue("adc", p.Opciones.Clientes.ActualizarDatos);
                    cmd3.Parameters.AddWithValue("f", p.Opciones.Clientes.Facturacion);
                    cmd3.Parameters.AddWithValue("g", p.Opciones.Clientes.Garantias);
                    
                    cmd3.Parameters.AddWithValue("hc", p.Opciones.Vendedores.HistoricoCierres);
                    cmd3.Parameters.AddWithValue("nv", p.Opciones.Vendedores.NiveldelVendedor);
                    cmd3.Parameters.AddWithValue("igv", p.Opciones.Vendedores.InformacionPersonal);
                    cmd3.Parameters.AddWithValue("adv", p.Opciones.Vendedores.ActualizarDatos);
                    cmd3.Parameters.AddWithValue("r", p.Opciones.Vendedores.Referencia);
                    cmd3.Parameters.AddWithValue("o", p.Opciones.Vendedores.Organizacion);

                    cmd3.Parameters.AddWithValue("re", p.Opciones.Vendedores.Ventas.Resumen);
                    cmd3.Parameters.AddWithValue("vp", p.Opciones.Vendedores.Ventas.VentasPersonales);
                    cmd3.Parameters.AddWithValue("vu", p.Opciones.Vendedores.Ventas.VentasUnidad);
                    cmd3.Parameters.AddWithValue("vud", p.Opciones.Vendedores.Ventas.DetalleVentasUnidad);
                    cmd3.Parameters.AddWithValue("er", p.Opciones.Vendedores.Ventas.EstadoReclutamiento);
                    cmd3.Parameters.AddWithValue("gp", p.Opciones.Vendedores.Ventas.GraficoProvincias);

                    int rst2 = cmd3.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    throw new Exception("Error ingresando el nuevo perfil " + ex.Message);
                }
                db.Close();
            }

        }

        public void Update(Perfil p)
        {
            using (SqlConnection db = new SqlConnection(_cnnstr))
            {
                try
                {
                    db.Open();
                  
                    StringBuilder insert = new StringBuilder();
                    insert.Append("UPDATE perfiles_sc SET nombre = @nombre,descripcion = @descripcion ");
                    insert.Append("WHERE id = @id");

                    SqlCommand cmd2 = new SqlCommand(insert.ToString(), db);
                    cmd2.Parameters.AddWithValue("id", p.Id);
                    cmd2.Parameters.AddWithValue("nombre", p.Nombre);
                    cmd2.Parameters.AddWithValue("descripcion", p.Descripcion);

                    int rst = cmd2.ExecuteNonQuery();

                    StringBuilder detalle = new StringBuilder();
                    detalle.Append("UPDATE accesos_perfil ");
                    detalle.Append("SET [buscar_cliente]=@bc,[informacion_general_cliente]=@igc,");
                    detalle.Append("[actualizar_datos_cliente] = @adc,[facturacion] = @f,[garantias] = @g,[historico_cierres] = @hc,");
                    detalle.Append("[nivel_vendedor] = @nv,[informacion_general_vendedor] = @igv,[actualizar_datos_vendedor] = @adv,");
                    detalle.Append("[referencias] = @r,[organizacion] = @o,[resumen] = @re,[ventas_personales] = @vp,");
                    detalle.Append("[ventas_unidad] = @vu,[ventas_unidad_detalle]=@vud,[estado_reclutamiento]=@er,[graficos_provincias]=@gp ");
                    detalle.Append("WHERE cod_perfil = @id");

                    SqlCommand cmd3 = new SqlCommand(detalle.ToString(), db);
                    cmd3.Parameters.AddWithValue("id", p.Id);
                    cmd3.Parameters.AddWithValue("bc", p.Opciones.Clientes.BuscarCliente);
                    cmd3.Parameters.AddWithValue("igc", p.Opciones.Clientes.InformacionGeneral);
                    cmd3.Parameters.AddWithValue("adc", p.Opciones.Clientes.ActualizarDatos);
                    cmd3.Parameters.AddWithValue("f", p.Opciones.Clientes.Facturacion);
                    cmd3.Parameters.AddWithValue("g", p.Opciones.Clientes.Garantias);

                    cmd3.Parameters.AddWithValue("hc", p.Opciones.Vendedores.HistoricoCierres);
                    cmd3.Parameters.AddWithValue("nv", p.Opciones.Vendedores.NiveldelVendedor);
                    cmd3.Parameters.AddWithValue("igv", p.Opciones.Vendedores.InformacionPersonal);
                    cmd3.Parameters.AddWithValue("adv", p.Opciones.Vendedores.ActualizarDatos);
                    cmd3.Parameters.AddWithValue("r", p.Opciones.Vendedores.Referencia);
                    cmd3.Parameters.AddWithValue("o", p.Opciones.Vendedores.Organizacion);

                    cmd3.Parameters.AddWithValue("re", p.Opciones.Vendedores.Ventas.Resumen);
                    cmd3.Parameters.AddWithValue("vp", p.Opciones.Vendedores.Ventas.VentasPersonales);
                    cmd3.Parameters.AddWithValue("vu", p.Opciones.Vendedores.Ventas.VentasUnidad);
                    cmd3.Parameters.AddWithValue("vud", p.Opciones.Vendedores.Ventas.DetalleVentasUnidad);
                    cmd3.Parameters.AddWithValue("er", p.Opciones.Vendedores.Ventas.EstadoReclutamiento);
                    cmd3.Parameters.AddWithValue("gp", p.Opciones.Vendedores.Ventas.GraficoProvincias);

                    
                    int rst2 = cmd3.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    throw new Exception("Error actualizando perfil " + ex.Message);
                }
                db.Close();
            }

        }

        public void Delete(Perfil p)
        {     
            using (SqlConnection db = new SqlConnection(_cnnstr))
            {
                StringBuilder query = new StringBuilder();
                query.Append("DELETE ");
                query.Append("FROM perfiles_sc ");
                query.Append("WHERE id = @id ");

                SqlCommand cmd = new SqlCommand(query.ToString(), db);
                cmd.Parameters.AddWithValue("id",p.Id);
                try
                {
                    db.Open();
                    
                    int rst = cmd.ExecuteNonQuery();
                    if (rst == 0)
                        throw new Exception("No se elimino el perfil");

                } catch (Exception ex)
                {
                    throw new Exception("Error eliminando el perfil " + ex.Message);
                }
                db.Close();
            }
        }
    }
}

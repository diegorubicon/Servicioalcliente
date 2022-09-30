using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UserAccessManager
{
    //Esta clase tiene la responsabilidad de caracterizar un perfil
    public class Perfil
    {
        public class InfoClientes
        {
           public bool BuscarCliente = false;
           public bool InformacionGeneral = false;
           public bool ActualizarDatos = false;
           public bool Facturacion = false;
           public  bool Garantias = false;
        }
        public class clsVentas
        {
           public bool Resumen = false;
           public bool VentasPersonales = false;
           public bool VentasUnidad = false;
           public bool DetalleVentasUnidad = false;
           public bool EstadoReclutamiento = false;
           public bool GraficoProvincias = false;
        }
    public class InfoVendedores
    {
        public bool HistoricoCierres = false;
        public bool NiveldelVendedor = false;
        public bool InformacionPersonal = false;
        public bool ActualizarDatos = false;
        public bool Referencia = false;
        public bool Organizacion = false;
        public clsVentas Ventas;       
        
        public InfoVendedores()
        {
            Ventas = new clsVentas();
        }
    }



        public class Accesos
        {
            public InfoClientes Clientes;
            public InfoVendedores Vendedores;
            public Accesos()
            {
                Clientes = new InfoClientes();
                Vendedores = new InfoVendedores();
            }
        }
    

        public decimal Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public Accesos Opciones { get; set; }

        public Perfil()
        {
            Opciones = new Accesos();
        }
    }
}

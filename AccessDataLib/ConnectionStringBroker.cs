using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Windows;
using System.Data.SqlClient;
using Serilog;

namespace AccessDataLib
{
    public class ConnectionStringBroker
    {
        private static ConnectionStringBroker instance = null;
        private ConnectionStringBroker()
        {
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Debug()              
                .WriteTo.File("logs\\ConnectionStringError.txt", rollingInterval: RollingInterval.Day)
                .CreateLogger();
        }
        public static ConnectionStringBroker Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ConnectionStringBroker();
                }
                return instance;
            }
        }        
        /// <summary>
        /// Obtiene la cadena de conexion con el nombre indicado
        /// </summary>
        /// <param name="connectionStringName">Nombre de la cadena de conexion</param>
        /// <returns>Cadena de conexion que pertence al nombre indicado</returns>
        public static string GetConnectionString(string connectionStringName)
        {
            System.Configuration.Configuration appconfig = null;
            if (System.Web.HttpContext.Current != null && !System.Web.HttpContext.Current.Request.PhysicalPath.Equals(string.Empty))
                appconfig = System.Web.Configuration.WebConfigurationManager.OpenWebConfiguration("~");
            else
                appconfig = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            ConnectionStringSettings connStringSettings = appconfig.ConnectionStrings.ConnectionStrings[connectionStringName];
            return connStringSettings.ConnectionString;
        }
        /// <summary>
        /// Obtiene los nombre de las cadenas de conexion en el archivo de configuracion
        /// </summary>
        /// <returns>Lista con el nombre de las cadenas de conexion</returns>
        public static List<string> GetConnectionStringNames()
        {
            List<string> cns = new List<string>();
            System.Configuration.Configuration appconfig = null;
            if (System.Web.HttpContext.Current != null && !System.Web.HttpContext.Current.Request.PhysicalPath.Equals(string.Empty))
                appconfig = System.Web.Configuration.WebConfigurationManager.OpenWebConfiguration("~");
            else
                appconfig = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            foreach (ConnectionStringSettings cn in appconfig.ConnectionStrings.ConnectionStrings)
            {
                cns.Add(cn.Name);
            }
            return cns;
        }
        /// <summary>
        /// Retorna el nombre de la primera cadena de conexion en el archivo de configuracion
        /// </summary>
        /// <returns>Nombre de la primera cadena de conexion</returns>
        public static string GetFirstConnectionStringName()
        {
            return GetConnectionStringNames().FirstOrDefault();
        }
        /// <summary>
        /// Retorma la primera cadena de conexion en el archivo de configuracion
        /// </summary>
        /// <returns>Primera cadena de conexion</returns>
        public static string GetFirstConnectionString()
        {
            return GetConnectionString(GetFirstConnectionStringName());
        }
        /// <summary>
        /// Guarda una cadena de conexion en el archivo app.config
        /// </summary>
        /// <param name="connectionStringName">Nombre de la cadena de conexion</param>
        /// <param name="connectionString">Cadena de conexion</param>
        public static void SaveConnectionString(string connectionStringName, string connectionString)
        {
            Configuration appconfig =
                ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            appconfig.ConnectionStrings.ConnectionStrings[connectionStringName].ConnectionString = connectionString;
            appconfig.Save();
        }
        public static string SetDataSourceLocation(string ConnectionStringName, string DataSourceLocation)
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder(GetConnectionString(ConnectionStringName));
            builder.DataSource = DataSourceLocation;

            SaveConnectionString(ConnectionStringName, builder.ConnectionString);

            return builder.ConnectionString;
        }
        public static System.Configuration.ConnectionStringSettings GetConnectionSettings(string connectionStringName)
        {
            try
            {
                System.Configuration.Configuration appconfig = null;
                if (System.Web.HttpContext.Current != null && !System.Web.HttpContext.Current.Request.PhysicalPath.Equals(string.Empty))
                    appconfig = System.Web.Configuration.WebConfigurationManager.OpenWebConfiguration("~");
                else
                    appconfig = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);


                ConnectionStringSettings connStringSettings = appconfig.ConnectionStrings.ConnectionStrings[connectionStringName];

                return connStringSettings;
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Something went wrong");
                return null;
            }
        }

    }
}

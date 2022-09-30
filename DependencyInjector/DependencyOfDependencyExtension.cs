using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;
using Unity.Extension;
using AccessDataLib;
using ServicioalCliente.Config;
using ServicioalCliente.Infrastructure.Repositories;

namespace SFC.DependencyInjector
{
    public class DependencyOfDependencyExtension : UnityContainerExtension
    {
        protected override void Initialize()
        {        

            //registra la conexion
            var connection = new ConnectionFactory("SakifConn");
            Container.RegisterInstance<IConnectionFactory>(connection, InstanceLifetime.Singleton);

            Container.RegisterType<IAppParameterRepository, AppParameterRepository>();
           
        }
    }
}

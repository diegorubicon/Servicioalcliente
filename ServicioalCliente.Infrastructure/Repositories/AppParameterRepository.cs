using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccessDataLib;
using ServicioalCliente.Config;

namespace ServicioalCliente.Infrastructure.Repositories
{
    public class AppParameterRepository  :  Repository<AppParameter, DTO.AppParameterDTO>, IAppParameterRepository
    {
       public AppParameterRepository(IConnectionFactory connectionFactory) : base(connectionFactory)
       {

       }
        public AppParameter getFirstParameter()
        {
            return base.getAll().FirstOrDefault();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServicioalCliente.Config;

namespace ServicioalCliente.Services
{
    public class CompanyParametersService
    {
        IAppParameterRepository appParameterRepository;

        public CompanyParametersService(IAppParameterRepository appParameterRepository)
        {
            this.appParameterRepository = appParameterRepository;
        }
        public AppParameter getParameters()
        {
            return appParameterRepository.getFirstParameter();
        }

    }
}

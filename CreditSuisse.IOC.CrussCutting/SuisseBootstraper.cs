using CreditSuisse.IOC.CrussCutting.Modules;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditSuisse.IOC.CrussCutting
{
    public class SuisseBootstraper
    {
        public static void RegisterServices(IServiceCollection container)
        {
            RepositoryModule.SetModules(container);
            ServiceModule.SetModules(container);
            ApplicationModule.SetModules(container);
        }
    }
}

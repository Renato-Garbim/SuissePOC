using CreditSuisse.Application.AppServices;
using CreditSuisse.Application.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditSuisse.IOC.CrussCutting.Modules
{
    public static class ApplicationModule
    {
        public static void SetModules(IServiceCollection container)
        {

            container.AddScoped<ITradeAppService, TradeAppService>();

        }
    }
}

using CreditSuisse.Domain.Services;
using CreditSuisse.Domain.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditSuisse.IOC.CrussCutting.Modules
{
    public static class ServiceModule
    {
        public static void SetModules(IServiceCollection container)
        {
            container.AddScoped<ITradeService, TradeService>();
        }
    }
}

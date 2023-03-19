using CreditSuisse.Infra.DAL;
using CreditSuisse.Infra.Repositories;
using CreditSuisse.Infra.Repositories.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditSuisse.IOC.CrussCutting.Modules
{
    public static class RepositoryModule
    {
        public static void SetModules(IServiceCollection container)
        {
            container.AddScoped<DbContextMock>();
            container.AddScoped<ITradeRepository, TradeRepository>();
        }
    }
}

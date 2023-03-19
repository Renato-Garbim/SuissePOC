using AutoMapper;
using CreditSuisse.Application.Automapper.Profile;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditSuisse.Application.Automapper
{
    public static class BootstraperAutomapper
    {
        public static Action<IMapperConfigurationExpression> ConfigAction = new Action<IMapperConfigurationExpression>(
cfg =>
{
    cfg.AllowNullCollections = true;
    cfg.AllowNullDestinationValues = true;


    cfg.AddProfile<TradeProfile>();

});

    }
}

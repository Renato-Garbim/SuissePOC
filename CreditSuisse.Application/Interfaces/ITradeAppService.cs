using CreditSuisse.Application.DTOs;
using CreditSuisse.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditSuisse.Application.Interfaces
{
    public interface ITradeAppService : IAppServiceBase<Trade, TradeDTO>
    {

    }
}

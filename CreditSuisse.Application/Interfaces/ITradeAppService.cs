using CreditSuisse.Application.DTOs;
using CreditSuisse.Domain.Entities;
using CreditSuisse.Framework.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditSuisse.Application.Interfaces
{
    public interface ITradeAppService : IAppServiceBase<Trade, TradeDTO>
    {
        TradeDTO CreateTradeFromStringValue(string tradeBody);
        List<CategoriesEnum> GetCategoryForEachTradeInPortfolio(List<TradeDTO> tradeListPortfolio, DateTime referenceDate);
    }
}

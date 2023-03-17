using CreditSuisse.Domain.Entities;
using CreditSuisse.Domain.Entities.Enum;
using CreditSuisse.Domain.Services.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditSuisse.Domain.Services.Interfaces
{
    public interface ITradeService : IServiceBase<Trade>
    {
        CategoriesEnum GetCategoryForTrade(Trade trade, DateTime ReferenceDate);
    }
}

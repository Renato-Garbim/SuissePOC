using CreditSuisse.Domain.Entities;
using CreditSuisse.Domain.Services.Base;
using CreditSuisse.Domain.Services.Interfaces;
using CreditSuisse.Framework.Enum;
using CreditSuisse.Infra.Base;
using CreditSuisse.Infra.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CreditSuisse.Domain.Services
{
    public class TradeService : ServiceBase<Trade>, ITradeService
    {
        private readonly IRepositoryBase<Trade> _tradeRepository;
        public TradeService(ITradeRepository repository) : base(repository)
        {
            _tradeRepository = repository;
        }

        public CategoriesEnum GetCategoryForTrade(Trade trade, DateTime referenceDate)
        {
            if (IsExpired(trade.NextPaymentDate, referenceDate)) return CategoriesEnum.Expired;
            if (IsMediumRisk(trade.Value, trade.ClientSector)) return CategoriesEnum.Mediumrisk;
            if (IsHighRisk(trade.Value, trade.ClientSector)) return CategoriesEnum.Highrisk;
                        
            return CategoriesEnum.None;
        }

        private bool IsExpired(DateTime nextPaymentDate, DateTime ReferenceDate)
        {
            var ts = new TimeSpan();
            ts = ReferenceDate - nextPaymentDate;

            return ts.Days > 30;
        }

        private bool IsMediumRisk(double tradeValue, ClientSectorEnum clientSector)
        {
            double paramValue = Convert.ToDouble(1000000);
            return tradeValue > paramValue && clientSector.ToString().ToLower().Equals("public");
        }

        private bool IsHighRisk(double tradeValue, ClientSectorEnum clientSector)
        {
            double paramValue = Convert.ToDouble(1000000);
            return tradeValue > paramValue && clientSector.ToString().ToLower().Equals("private");
        }

    }
}

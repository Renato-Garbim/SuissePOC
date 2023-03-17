using CreditSuisse.Domain.Entities;
using CreditSuisse.Domain.Entities.Enum;
using CreditSuisse.Domain.Services.Base;
using CreditSuisse.Domain.Services.Interfaces;
using CreditSuisse.Infra.Base;
using CreditSuisse.Infra.Repositories.Interfaces;
using System;
using System.Collections.Generic;
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

        public CategoriesEnum GetCategoryForTrade(Trade trade, DateTime ReferenceDate)
        {
            var ts = new TimeSpan();
            ts = ReferenceDate - trade.NextPaymentDate;
            double minValue = Convert.ToDouble(1000000);


            if (ts.Days > 30) return CategoriesEnum.Expired;
            if (trade.Value > minValue && trade.ClientSector.ToString().ToLower().Equals("private")) return CategoriesEnum.Highrisk;
            if (trade.Value > minValue && trade.ClientSector.ToString().ToLower().Equals("public")) return CategoriesEnum.Mediumrisk;

            return CategoriesEnum.None;
        }
    }
}

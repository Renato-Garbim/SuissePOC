using AutoMapper;
using CreditSuisse.Application.AppBase;
using CreditSuisse.Application.DTOs;
using CreditSuisse.Application.Interfaces;
using CreditSuisse.Domain.Entities;
using CreditSuisse.Domain.Services.Interfaces;
using CreditSuisse.Framework.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditSuisse.Application.AppServices
{
    public class TradeAppService : AppServiceBase<Trade, TradeDTO>, ITradeAppService
    {
        private readonly ITradeService _tradeService;

        public TradeAppService(ITradeService tradeService, IMapper mapper) : base(tradeService, mapper)
        {
            _tradeService = tradeService;
        }

        public List<CategoriesEnum> GetCategoryForEachTradeInPortfolio(List<TradeDTO> tradeListPortfolio, DateTime referenceDate)
        {
            var listCategories = new List<CategoriesEnum>();
            
            foreach (var trade in tradeListPortfolio)
            {
                var entity = Mapper.Map<Trade>(trade);
                CategoriesEnum category = _tradeService.GetCategoryForTrade(entity, referenceDate);

                listCategories.Add(category);
            }

            return listCategories;
        }

        public TradeDTO CreateTradeFromStringValue(string tradeBody)
        {
            var values = tradeBody.Split().ToList();

            double tradeValue = Convert.ToDouble(values.First());

            values.RemoveAt(0);

            ClientSectorEnum clientSector = (ClientSectorEnum)Enum.Parse(typeof(ClientSectorEnum), values.First().ToLower(), true);

            values.RemoveAt(0);

            DateTime tradePendingPayment = DateTime.Parse(values.First());

            var trade = new TradeDTO();
            trade.Value = tradeValue;
            trade.ClientSector = clientSector;
            trade.NextPaymentDate = tradePendingPayment;

            return trade;

        }

    }
}

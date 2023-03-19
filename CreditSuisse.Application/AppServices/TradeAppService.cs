using AutoMapper;
using CreditSuisse.Application.AppBase;
using CreditSuisse.Application.DTOs;
using CreditSuisse.Application.Interfaces;
using CreditSuisse.Domain.Entities;
using CreditSuisse.Domain.Services.Interfaces;
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


    }
}

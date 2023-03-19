using CreditSuisse.Application.DTOs;
using CreditSuisse.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditSuisse.Application.Automapper.Profile
{
    public class TradeProfile : global::AutoMapper.Profile    
    {
        public TradeProfile()
        {
            CreateMap<Trade, TradeDTO>().ReverseMap();

            //CreateMap<TradeDTO, Trade>()
            //    .ConstructUsing(x => new Trade(x.Value, x.ClientSector,  x.NextPaymentDate));
            
        }

    }
}

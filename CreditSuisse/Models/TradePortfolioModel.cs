using CreditSuisse.Application.DTOs;
using CreditSuisse.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditSuisse.Models
{
    public class TradePortfolioModel
    {
        public DateTime ReferenceDate { get; set; }
        public int TradeQuantity { get; set; }
        public List<TradeDTO> TradeList { get; set; }

        public TradePortfolioModel()
        {
            TradeList= new List<TradeDTO>();
        }
    }
}

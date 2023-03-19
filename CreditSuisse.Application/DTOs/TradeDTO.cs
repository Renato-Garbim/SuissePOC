using CreditSuisse.Application.AppBase.DTOBase;
using CreditSuisse.Framework.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditSuisse.Application.DTOs
{
    public class TradeDTO : DTOBase
    {
        public int TradeId { get; set; }
        public Guid TradeGuid { get; set; }
        public double Value { get; set; }
        public ClientSectorEnum ClientSector { get; set; }
        public DateTime NextPaymentDate { get; set; }
    }
}

using CreditSuisse.Domain.Entities.Base;
using CreditSuisse.Framework.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditSuisse.Domain.Entities
{
    public class Trade : EntityBase
    {
        public int TradeId { get; private set; }
        public Guid TradeGuid { get; private set; }
        public double Value { get; private set; }
        public ClientSectorEnum ClientSector { get; private set; }
        public DateTime NextPaymentDate { get; private set; }

        public Trade(int tradeId, Guid tradeGuid, double value, ClientSectorEnum clientSector, DateTime nextPaymentDate)
        {
            TradeId = tradeId;
            TradeGuid = tradeGuid;
            Value = value;
            ClientSector = clientSector;
            NextPaymentDate = nextPaymentDate;
        }
    }
}

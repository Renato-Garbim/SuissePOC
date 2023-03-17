using CreditSuisse.Domain.Entities.Base;
using CreditSuisse.Domain.Entities.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditSuisse.Domain.Entities
{
    public class Trade : EntityBase
    {        
        public double Value { get; private set; }
        public ClientSectorEnum ClientSector { get; private set; }
        public DateTime NextPaymentDate { get; private set; }

        public Trade(double value, ClientSectorEnum clientSector, DateTime nextPaymentDate)
        {
            Value = value;
            ClientSector = clientSector;
            NextPaymentDate = nextPaymentDate;
        }


    }
}

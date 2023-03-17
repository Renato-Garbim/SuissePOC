using CreditSuisse.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditSuisse.Infra.DAL
{
    public class DbContextMock
    {
        public IList<Trade> tradeBase;

        public DbContextMock()
        {
            tradeBase= new List<Trade>();
        }
        
    }
}

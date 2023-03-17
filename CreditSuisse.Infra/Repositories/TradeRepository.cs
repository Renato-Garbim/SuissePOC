using CreditSuisse.Domain.Entities;
using CreditSuisse.Infra.Base;
using CreditSuisse.Infra.DAL;
using CreditSuisse.Infra.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditSuisse.Infra.Repositories
{
    public class TradeRepository : RepositoryBase<Trade>, ITradeRepository
    {
        public TradeRepository(DbContextMock db) : base(db)
        {
        }
    }
}

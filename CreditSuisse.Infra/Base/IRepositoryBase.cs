using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditSuisse.Infra.Base
{
    public interface IRepositoryBase<TEntity> : IUnityOfWork where TEntity : class
    {
        bool InsertRecord(TEntity obj);
        bool UpdateRecord(TEntity obj);
    }
}

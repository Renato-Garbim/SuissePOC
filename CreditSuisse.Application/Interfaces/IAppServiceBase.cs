using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditSuisse.Application.Interfaces
{
    public interface IAppServiceBase<TEntity, TEntityViewModel> where TEntity : class where TEntityViewModel : class
    {
        bool AddOrUpdate(TEntityViewModel obj);

    }
}

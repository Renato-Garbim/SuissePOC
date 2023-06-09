﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditSuisse.Domain.Services.Base
{
    public interface IServiceBase<TEntity> where TEntity : class 
    {
        bool InsertRecord(TEntity objeto);
        bool UpdateRecord(TEntity objeto);
        Task CommitAsync();
        void Rollback();
        void Dispose();
    }
}

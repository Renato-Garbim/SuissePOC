using CreditSuisse.Infra.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditSuisse.Domain.Services.Base
{
    public class ServiceBase<TEntity> : IServiceBase<TEntity> where TEntity : class
    {
        private readonly IRepositoryBase<TEntity> _repository;

        public ServiceBase(IRepositoryBase<TEntity> repository)
        {
            _repository = repository;
        }

        public bool InsertRecord(TEntity objeto)
        {

            return _repository.InsertRecord(objeto);
        }

        public bool UpdateRecord(TEntity objeto)
        {
            return _repository.UpdateRecord(objeto);
        }

        public Task CommitAsync()
        {
            return _repository.CommitAsync();
        }

        public void Rollback()
        {
            _repository.Rollback();
        }

        public void Dispose()
        {
            _repository.Dispose();
        }


    }
}

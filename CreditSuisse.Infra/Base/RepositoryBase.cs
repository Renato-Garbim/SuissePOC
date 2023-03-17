using CreditSuisse.Infra.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditSuisse.Infra.Base
{
    public class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : class
    {
        protected DbContextMock Db { get; private set; }

        //EntityFramework Implemetation
        //protected readonly DbSet<TEntity> DBSet;

        // for future implementation of a dapper 
        private readonly string _strConexao;

        public RepositoryBase(DbContextMock db)
        {
            Db = db;
            if (db == null)
                throw new ArgumentNullException(nameof(db));

            //DBSet = Db.Set<TEntity>();
           // _strConexao = Db.Database.GetDbConnection().ConnectionString;
        }

        public Task CommitAsync()
        {            
            return Task.CompletedTask;
            //return Db.SaveChangesAsync();
        }

        public void Rollback()
        {
            //Db.Rollback();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                //Db.Dispose();
            }
        }

    }
}

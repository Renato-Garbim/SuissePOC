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

            //EntityFramework Implemetation
            //DBSet = Db.Set<TEntity>();
            // _strConexao = Db.Database.GetDbConnection().ConnectionString;
        }

        public virtual bool InsertRecord(TEntity obj)
        {
            var sucess = false;

            //Db.GetType().GetProperty
                //Db.tradeBase.Add(obj);
                //AlterarBanco();

                sucess = true;

            return sucess;
        }

        public virtual bool UpdateRecord(TEntity obj)
        {
            var sucess = false;

            return sucess;
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

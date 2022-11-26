using OnionExample.Application.Context;
using OnionExample.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionExample.Application.Services
{
    public class UnitOfWork : IDisposable, IUnitOfWork
    {
        protected OnionDbContext dbContext;
        public UnitOfWork(OnionDbContext _dbContext)
        {
            dbContext = _dbContext;
        }
        public void Dispose()
        {
            dbContext.Dispose();
            GC.SuppressFinalize(this);
        }

        public IRepository<T> GetRepository<T>() where T : class
        {
            return new Repository<T>(dbContext);
        }

        public int SaveChanges()
        {
            return dbContext.SaveChanges();
        }
    }
}

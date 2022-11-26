using Microsoft.EntityFrameworkCore;
using OnionExample.Application.Context;
using OnionExample.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionExample.Application.Services
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected OnionDbContext dbContext;
        protected DbSet<T> dbSet;
        public Repository(OnionDbContext _dbContext)
        {
            dbContext = _dbContext;
            dbSet = dbContext.Set<T>();
        }
        public void Add(T model)
        {
            dbSet.Add(model);
        }

        public void Delete(T model)
        {
            dbSet.Remove(model);
        }

        public T Get(int id)
        {
            throw new NotImplementedException();
        }

        public T Get(Func<T, bool> expression)
        {
            var data = dbSet.Where(expression);
            return data.FirstOrDefault();
        }

        public IQueryable<T> GetAll()
        {
            return dbSet;
        }

        public IQueryable<T> GetAll(Func<T, bool> expression)
        {
            var data = dbSet.Where(expression);
            return data.AsQueryable();
        }

        public void Update(T model)
        {
            dbSet.Attach(model);
            dbContext.Entry(model).State = EntityState.Modified;
        }
    }
}

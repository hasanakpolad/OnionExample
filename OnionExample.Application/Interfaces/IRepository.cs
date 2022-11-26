using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionExample.Application.Interfaces
{
    public interface IRepository<T> where T : class
    {
        void Add(T model);
        void Update(T model);
        void Delete(T model);
        T Get(int id);
        T Get(Func<T, bool> expression);
        IQueryable<T> GetAll();
        IQueryable<T> GetAll(Func<T, bool> expression);
    }
}

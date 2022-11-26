using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionExample.Application.Interfaces
{
    public interface IUnitOfWork
    {
        int SaveChanges();
        IRepository<T> GetRepository<T>() where T : class;
    }
}

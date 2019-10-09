using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DbTest.Repository
{
    public interface IRepository<T>
    {
        IQueryable<T> FindAll();
        bool Create(T entity);
        T Find(int id);
        bool Update(T entity);
        bool Delete(int id);
    }
}
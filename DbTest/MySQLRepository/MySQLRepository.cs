using DbTest.Models;
using DbTest.Utility;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DbTest.Repository
{
    public class MySQLRepository<T>:IRepository<T> where T : class
    {
        protected RepositoryContext RepositoryContext { get; set; }

        public MySQLRepository(RepositoryContext repositoryContext)
        {
            this.RepositoryContext = repositoryContext;
        }

        public IQueryable<T> FindAll()
        {
            return this.RepositoryContext.Set<T>().AsNoTracking();
        }

        public bool Create(T entity)
        {
           T t=this.RepositoryContext.Set<T>().Add(entity).Entity;
            return true;
        }

        public T Find(int id)
        {
            T t = this.RepositoryContext.Set<T>().Find(id);
            return t;
        }

        public bool Update(T entity)
        {
            T t= this.RepositoryContext.Set<T>().Update(entity).Entity;
            return true;
        }

        public bool Delete(int id)
        {
            T entity = this.RepositoryContext.Set<T>().Find(id);
             this.RepositoryContext.Set<T>().Remove(entity);
            return true;
        }
    }
}

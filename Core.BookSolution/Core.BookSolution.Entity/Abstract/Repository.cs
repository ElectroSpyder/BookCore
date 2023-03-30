using Core.BookSolution.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.BookSolution.Entity.Abstract
{
    public abstract class Repository<T> : IRepository<T> where T : class
    {
        protected readonly DbContext dbContext;

        protected Repository(DbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void Add(T entity)
        {
            dbContext.Set<T>().Add(entity);
        }

        public T Get(int id)
        {
            return dbContext.Set<T>().Find(id);
        }

        public IEnumerable<T> GetAll()
        {
            return dbContext.Set<T>().ToList();
        }

        public void Remove(T entity)
        {
            dbContext.Set<T>().Remove(entity);
        }
    }
}

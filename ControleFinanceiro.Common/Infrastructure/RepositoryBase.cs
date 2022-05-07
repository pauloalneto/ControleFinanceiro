using ControleFinanceiro.Common.Interface.Infrastructure;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiro.Common.Infrastructure
{
    public abstract class RepositoryBase<T> : IRepository<T> where T : class
    {
        protected DbContext context;
        protected DbSet<T> dbSet;

        public RepositoryBase(DbContext context)
        {
            this.context = context;
            this.dbSet = this.context.Set<T>();
        }

        public IQueryable<T> GetAll()
        {
            return this.dbSet.AsNoTracking();
        }

        public T Add(T entity)
        {
            var result = this.dbSet.Add(entity).Entity;

            this.Save();

            return result;
        }

        public T Update(T entity)
        {
            var entry = this.context.Update(entity);
            this.dbSet.Attach(entity);
            entry.State = EntityState.Modified;

            this.Save();

            return entity;
        }

        public void Remove(T entity)
        {
            this.dbSet.Remove(entity);
            this.Save();
        }

        public void Save()
        {
            this.context.SaveChanges();
        }

    }
}

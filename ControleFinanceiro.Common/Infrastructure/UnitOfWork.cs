using ControleFinanceiro.Common.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ControleFinanceiro.Common.Infrastructure
{
    public class UnitOfWork<T> : IUnitOfWork
    {
        private DbContext context;
        private IDbContextTransaction transaction;
        private bool disposed;

        public UnitOfWork(T context)
        {
            this.context = context as DbContext;
        }

        public void BeginTransaction()
        {
            this.transaction = this.context.Database.BeginTransaction();
            this.disposed = false;
    }

        public int Commit()
        {
            var result = this.context.SaveChanges();
            this.transaction.Commit();
            return result;
        }

        public Task<int> CommitAsync()
        {
            var result = this.context.SaveChangesAsync();
            this.transaction.Commit();
            return result;
        }

        protected virtual void Dispose(bool disposing)
        {

            if (!disposed)
            {
                if (disposing)
                {
                    this.context.Dispose();
                }
            }

        }
    }
}

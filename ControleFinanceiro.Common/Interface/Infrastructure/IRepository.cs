﻿using System.Collections.Generic;
using System.Linq;

namespace ControleFinanceiro.Common.Interface.Infrastructure
{
    public interface IRepository<T>
    {
        IQueryable<T> GetAll();

        T Add(T entity);
        T Update(T entity);
        void Remove(T entity);
        void Save();
    }
}

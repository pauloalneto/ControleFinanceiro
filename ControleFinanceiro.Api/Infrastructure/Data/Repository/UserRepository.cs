﻿using ControleFinanceiro.Api.Domain.Entity;
using ControleFinanceiro.Api.Domain.Interface.Repository;
using ControleFinanceiro.Api.Infrastructure.Data.Context;
using ControleFinanceiro.Common.Infrastructure;
using System.Linq;

namespace ControleFinanceiro.Api.Infrastructure.Data.Repository
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public UserRepository(ControleFinanceiroContext context) : base(context)
        {
        }

        public User GetById(int id)
        {
            return this.GetAll().SingleOrDefault(_ => _.Id == id);
        }
    }
}

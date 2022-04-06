﻿using ControleFinanceiro.Api.Domain.Entity;
using ControleFinanceiro.Common.Interface.Infrastructure;

namespace ControleFinanceiro.Api.Domain.Interface.Repository
{
    public interface IRoleRepository : IRepository<Role>
    {
        Role GetById(int id);
    }
}

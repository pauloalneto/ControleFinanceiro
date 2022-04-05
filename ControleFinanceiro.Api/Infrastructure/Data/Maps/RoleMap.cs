﻿using ControleFinanceiro.Api.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ControleFinanceiro.Api.Infrastructure.Data.Maps
{
    public class RoleMap
    {
        public RoleMap(EntityTypeBuilder<Role> typeBuilder)
        {
            typeBuilder.ToTable("Role");
            typeBuilder.Property(_ => _.Id).HasColumnName("Id");
            typeBuilder.Property(_ => _.Name).HasColumnName("Name").HasColumnType("varchar(250)");

            typeBuilder.HasKey(_ => _.Id);
        }
    }
}

﻿using ControleFinanceiro.Api.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ControleFinanceiro.Api.Infrastructure.Data.Maps
{
    public class AccessLogMap
    {
        public AccessLogMap(EntityTypeBuilder<AccessLog> typeBuilder)
        {
            typeBuilder.ToTable("AccessLog");
            typeBuilder.Property(_ => _.Id).HasColumnName("Id");
            typeBuilder.Property(_ => _.UserId).HasColumnName("UserId");
            typeBuilder.Property(_=> _.Action).HasColumnName("Action").HasColumnType("varchar(250)");
            typeBuilder.Property(_=> _.ActionDate).HasColumnName("ActionDate");

            typeBuilder.HasKey(_ => _.Id);
        }
    }
}

using ControleFinanceiro.Api.Domain.Entity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace ControleFinanceiro.Api.Infrastructure.Data.Maps
{
    public class BankMap
    {
        public BankMap(EntityTypeBuilder<Bank> typeBuilder)
        {
            typeBuilder.ToTable("Bank");
            typeBuilder.Property(_=>_.Id).HasColumnName("Id");
            typeBuilder.Property(_=>_.Name).HasColumnName("Name").HasColumnType("varchar(250)");
            typeBuilder.Property(_=>_.UserCreateId).HasColumnName("UserCreateId");
            typeBuilder.Property(_=>_.UserCreateDate).HasColumnName("UserCreateDate");
            typeBuilder.Property(_=>_.UserAlterId).HasColumnName("UserAlterId");
            typeBuilder.Property(_=>_.UserAlterDate).HasColumnName("UserAlterDate");

            typeBuilder.HasKey(_=>_.Id);
        }
    }
}

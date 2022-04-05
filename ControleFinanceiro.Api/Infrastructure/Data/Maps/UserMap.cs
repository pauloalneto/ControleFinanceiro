using ControleFinanceiro.Api.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ControleFinanceiro.Api.Infrastructure.Data.Maps
{
    public class UserMap
    {
        public UserMap(EntityTypeBuilder<User> typeBuilder)
        {
            typeBuilder.ToTable("User");
            typeBuilder.Property(_ => _.Id).HasColumnName("Id");
            typeBuilder.Property(_ => _.Name).HasColumnName("Name").HasColumnType("varchar(250)");
            typeBuilder.Property(_ => _.Email).HasColumnName("Email").HasColumnType("varchar(250)");
            typeBuilder.Property(_ => _.Login).HasColumnName("Login").HasColumnType("varchar(250)");
            typeBuilder.Property(_ => _.Password).HasColumnName("Password").HasColumnType("varchar(250)");
            typeBuilder.Property(_ => _.FirstAccess).HasColumnName("FirstAccess");

            typeBuilder.HasKey(_ => _.Id);
        }
    }
}

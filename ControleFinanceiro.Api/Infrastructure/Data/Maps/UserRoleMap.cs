using ControleFinanceiro.Api.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ControleFinanceiro.Api.Infrastructure.Data.Maps
{
    public class UserRoleMap
    {
        public UserRoleMap(EntityTypeBuilder<UserRole> typeBuilder)
        {
            typeBuilder.ToTable("UserRole");
            typeBuilder.Property(_ => _.UserId).HasColumnName("UserId");
            typeBuilder.Property(_ => _.RoleId).HasColumnName("RoleId");

            typeBuilder.HasKey(_ => new { _.UserId, _.RoleId });
        }
    }
}

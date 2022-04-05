using ControleFinanceiro.Api.Domain.Entity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace ControleFinanceiro.Api.Infrastructure.Data.Maps
{
    public class CardPaymentTypeMap
    {
        public CardPaymentTypeMap(EntityTypeBuilder<CardPaymentType> typeBuilder)
        {
            typeBuilder.ToTable("CardPaymentType");
            typeBuilder.Property(_ => _.CardId).HasColumnName("CardId");
            typeBuilder.Property(_ => _.PaymentTypeId).HasColumnName("PaymentTypeId");

            typeBuilder.HasKey(_ => new { _.CardId, _.PaymentTypeId});
        }
    }
}

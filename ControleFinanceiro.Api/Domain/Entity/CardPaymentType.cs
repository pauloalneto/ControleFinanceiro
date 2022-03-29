namespace ControleFinanceiro.Api.Domain.Entity
{
    public class CardPaymentType
    {
        public virtual int CardId { get; protected set; }
        public virtual int PaymentTypeId { get; protected set; }

        public virtual Card Card { get; protected set; }
        public virtual PaymentType PaymentType { get; protected set; }
    }
}

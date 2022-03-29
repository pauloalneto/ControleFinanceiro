using System;
using ControleFinanceiro.Common.Domain;

namespace ControleFinanceiro.Api.Domain.Entity
{
    public class AccessLog : EntityBase
    {
        public virtual int UserId { get; protected set; }
        public virtual string Action { get; protected set; }
        public virtual DateTime ActionDate { get; protected set; }

        public virtual User User { get; protected set; }


    }
}

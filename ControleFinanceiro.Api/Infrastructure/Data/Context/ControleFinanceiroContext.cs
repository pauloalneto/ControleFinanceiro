﻿using ControleFinanceiro.Api.Domain.Entity;
using ControleFinanceiro.Api.Infrastructure.Data.Maps;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace ControleFinanceiro.Api.Infrastructure.Data.Context
{
    public class ControleFinanceiroContext : DbContext
    {
        private IConfiguration configuration;
        public ControleFinanceiroContext(DbContextOptions<ControleFinanceiroContext> options,
            IConfiguration configuration) : base(options)
        {
            this.configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(this.configuration.GetConnectionString("DefaultConnection"));
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new AccessLogMap(modelBuilder.Entity<AccessLog>());
            new BankMap(modelBuilder.Entity<Bank>());
            new CardMap(modelBuilder.Entity<Card>());
            new CardPaymentTypeMap(modelBuilder.Entity<CardPaymentType>());
            new ExpenseMap(modelBuilder.Entity<Expense>());
            new ExpenseTypeMap(modelBuilder.Entity<ExpenseType>());
            new InvoiceExpenseMap(modelBuilder.Entity<InvoiceExpense>());
            new InvoiceMap(modelBuilder.Entity<Invoice>());
            new PaymentTypeMap(modelBuilder.Entity<PaymentType>());
            new RoleMap(modelBuilder.Entity<Role>());
            new UserMap(modelBuilder.Entity<User>());
            new UserRoleMap(modelBuilder.Entity<UserRole>());

            base.OnModelCreating(modelBuilder);
        }
    }
}

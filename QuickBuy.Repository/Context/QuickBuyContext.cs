using Microsoft.EntityFrameworkCore;
using QuickBuy.Domain.Entity;
using QuickBuy.Domain.ValueObject;
using QuickBuy.Repository.Config;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Repository.Context
{
    public class QuickBuyContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<ItemOrder> ItemOrders { get; set; }
        public DbSet<PaymentForm> PaymentForm { get; set; }


        public QuickBuyContext(DbContextOptions options) : base(options) {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new OrderConfiguration());
            modelBuilder.ApplyConfiguration(new ItemOrderConfiguration());
            modelBuilder.ApplyConfiguration(new PaymentFormConfiguration());
            modelBuilder.Entity<PaymentForm>().HasData(
                new PaymentForm() {
                    Id = 1,
                    Name = "Boleto",
                    Description = "Forma de Pagamento Boleto"
                },
                new PaymentForm() {
                    Id = 2,
                    Name = "Cartao de Crédito",
                    Description = "Forma de Pagamento Cartão de Crédito"
                },
                new PaymentForm() {
                    Id = 3,
                    Name = "Depósito",
                    Description = "Forma de Pagamento Depósito"
                }
                );
            base.OnModelCreating(modelBuilder);
        }
    }
}

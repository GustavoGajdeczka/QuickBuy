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
            modelBuilder.ApplyConfiguration(new OrderConfiguration());
            modelBuilder.ApplyConfiguration(new PaymentFormConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new ItemOrderConfiguration());
            base.OnModelCreating(modelBuilder);
        }
    }
}

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Repository.Config
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder) {
            builder.HasKey(o => o.Id);
            builder.Property(o => o.OrderDate).IsRequired();
            builder.Property(o => o.UserId).IsRequired();
            builder.Property(o => o.DeliveryDate).IsRequired();
            builder.Property(o => o.CEP).IsRequired();
            builder.Property(o => o.State).IsRequired();
            builder.Property(o => o.City).IsRequired();
            builder.Property(o => o.FullAdress).IsRequired();
            builder.Property(o => o.AdressNumber).IsRequired();
            builder.Property(o => o.PaymentForm).IsRequired();
            builder.Property(o => o.PaymentFormId).IsRequired();
        }
    }
}

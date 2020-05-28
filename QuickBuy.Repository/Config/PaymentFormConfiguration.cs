using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Domain.ValueObject;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Repository.Config
{
    public class PaymentFormConfiguration : IEntityTypeConfiguration<PaymentForm>
    {
        public void Configure(EntityTypeBuilder<PaymentForm> builder) {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Name).IsRequired();
            builder.Property(p => p.Description);
        }
    }
}

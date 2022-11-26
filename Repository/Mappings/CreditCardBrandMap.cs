﻿using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Mappings
{
    public class CreditCardBrandMap : IEntityTypeConfiguration<CreditCardBrand>
    {
        public void Configure(EntityTypeBuilder<CreditCardBrand> builder)
        {
            builder.ToTable("CreditCardBrand");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name).IsRequired().HasMaxLength(20);
            builder.Property(x => x.Active).IsRequired().HasDefaultValueSql("1");
            builder.Property(x => x.CreationDate).IsRequired().HasDefaultValueSql("getdate()");
        }
    }
}

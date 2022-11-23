using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Mappings
{
    public class CustomerMap : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.ToTable("Customer");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name).IsRequired().HasMaxLength(100);
            builder.Property(x => x.Cpf).IsRequired();
            builder.Property(x => x.Gender).IsRequired().HasMaxLength(1);
            builder.Property(x => x.Phone).IsRequired().HasMaxLength(13);
            builder.Property(x => x.Email).IsRequired().HasMaxLength(90);
            builder.Property(x => x.Login).IsRequired().HasMaxLength(20);
            builder.Property(x => x.Address).IsRequired().HasMaxLength(100);
            builder.Property(x => x.Complement).HasMaxLength(30);
            builder.Property(x => x.Neighborhood).IsRequired().HasMaxLength(50);
            builder.Property(x => x.County).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Country).IsRequired().HasMaxLength(30);
            builder.Property(x => x.Uf).IsRequired().HasMaxLength(2);
            builder.Property(x => x.ZipCode).IsRequired().HasMaxLength(10);
            builder.Property(x => x.Active).IsRequired();
        }
    }
}

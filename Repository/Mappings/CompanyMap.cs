using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Mappings
{
    public class CompanyMap : IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> builder)
        {
            // TODO: Criar índice
            
            builder.ToTable("Company");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name).IsRequired().HasMaxLength(60);
            builder.Property(x => x.CommercialName).IsRequired().HasMaxLength(60);
            builder.Property(x => x.Cnpj).IsRequired().HasMaxLength(18);
            builder.Property(x => x.Contact).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Ddd).IsRequired().HasMaxLength(2);
            builder.Property(x => x.Phone).IsRequired().HasMaxLength(9);
            builder.Property(x => x.WebSite).HasMaxLength(90);
            builder.Property(x => x.Email).IsRequired().HasMaxLength(90);
            builder.Property(x => x.Address).IsRequired().HasMaxLength(100);
            builder.Property(x => x.Complement).HasMaxLength(30);
            builder.Property(x => x.Neighborhood).IsRequired().HasMaxLength(50);
            builder.Property(x => x.County).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Country).IsRequired().HasMaxLength(30);
            builder.Property(x => x.UF).IsRequired().HasMaxLength(2);
            builder.Property(x => x.ZipCode).IsRequired().HasMaxLength(10);
            builder.Property(x => x.Active).IsRequired().HasDefaultValueSql("1");
            builder.Property(x => x.CreationDate).IsRequired().HasDefaultValueSql("getdate()");
        }
    }
}

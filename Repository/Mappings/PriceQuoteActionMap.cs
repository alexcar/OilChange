using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Mappings
{
    public class PriceQuoteActionMap : IEntityTypeConfiguration<PriceQuoteAction>
    {
        public void Configure(EntityTypeBuilder<PriceQuoteAction> builder)
        {
            builder.ToTable("PriceQuoteAction");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name).IsRequired().HasMaxLength(60);
            builder.Property(x => x.Active).IsRequired().HasDefaultValueSql("1");
            builder.Property(x => x.CreationDate).IsRequired().HasDefaultValueSql("getdate()");
        }
    }
}

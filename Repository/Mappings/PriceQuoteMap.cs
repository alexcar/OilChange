using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Mappings
{
    public class PriceQuoteMap : IEntityTypeConfiguration<PriceQuote>
    {
        public void Configure(EntityTypeBuilder<PriceQuote> builder)
        {
            builder.ToTable("PriceQuote");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Comments).IsRequired().HasMaxLength(100);
            builder.Property(x => x.PriceQuoteNumber).IsRequired().ValueGeneratedOnAdd();
            builder.Property(x => x.Active).IsRequired().HasDefaultValueSql("1");
            builder.Property(x => x.CreationDate).IsRequired().HasDefaultValueSql("getdate()");

            builder.Property(x => x.Active).IsRequired();

        }
    }
}

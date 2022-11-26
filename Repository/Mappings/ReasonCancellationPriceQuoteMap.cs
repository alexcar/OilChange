using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Mappings
{
    public class ReasonCancellationPriceQuoteMap : IEntityTypeConfiguration<ReasonCancellationPriceQuote>
    {
        public void Configure(EntityTypeBuilder<ReasonCancellationPriceQuote> builder)
        {
            builder.ToTable("ReasonCancellationPriceQuote");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name).IsRequired().HasMaxLength(60);
            builder.Property(x => x.Active).IsRequired().HasDefaultValueSql("1");
            builder.Property(x => x.CreationDate).IsRequired().HasDefaultValueSql("getdate()");
        }
    }
}

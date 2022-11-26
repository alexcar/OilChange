using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Mappings
{
    public class VehicleFuelMap : IEntityTypeConfiguration<VehicleFuel>
    {
        public void Configure(EntityTypeBuilder<VehicleFuel> builder)
        {
            builder.ToTable("VehicleFuel");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name).IsRequired().HasMaxLength(10);
            builder.Property(x => x.Active).IsRequired().HasDefaultValueSql("1");
            builder.Property(x => x.CreationDate).IsRequired().HasDefaultValueSql("getdate()");
        }
    }
}

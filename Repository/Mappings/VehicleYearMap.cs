using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Mappings
{
    public class VehicleYearMap : IEntityTypeConfiguration<VehicleYear>
    {
        public void Configure(EntityTypeBuilder<VehicleYear> builder)
        {
            builder.ToTable("VehicleYear");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name).IsRequired().HasMaxLength(4);
            builder.Property(x => x.Active).IsRequired();
            builder.Property(x => x.UserUpdate).IsRequired();
            builder.Property(x => x.CreationDate).IsRequired();
        }
    }
}

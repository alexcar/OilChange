using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Mappings
{
    public class VehicleMap : IEntityTypeConfiguration<Vehicle>
    {
        public void Configure(EntityTypeBuilder<Vehicle> builder)
        {
            builder.ToTable("Vehicle");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.LicencePlate).IsRequired().HasMaxLength(15);
            builder.Property(x => x.Active).IsRequired();
            builder.Property(x => x.UserUpdate).IsRequired();
            builder.Property(x => x.CreationDate).IsRequired();
        }
    }
}

using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Mappings
{
    public class InfrastructureMap : IEntityTypeConfiguration<Infrastructure>
    {
        public void Configure(EntityTypeBuilder<Infrastructure> builder)
        {
            builder.ToTable("Infrastructure");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name).IsRequired().HasMaxLength(60);
            builder.Property(x => x.Active).IsRequired();

            //builder
            //    .HasOne(i => i.Company)
            //    .WithMany(c => c.Infrastructures)
            //    .OnDelete(DeleteBehavior.NoAction);

            builder
                .HasMany(i => i.Companies)
                .WithMany(c => c.Infrastructures)
                .UsingEntity(j => j.ToTable("InfrastructureCompany"));
        }
    }
}
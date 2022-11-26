using Entities.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Repository
{
    public class RepositoryContext : IdentityDbContext<User>
    {
        public RepositoryContext(DbContextOptions options): base(options)
        {

        }

        public DbSet<Company>? Companies { get; set; }
        public DbSet<CompanyUser>? CompanyUsers { get; set; }
        public DbSet<CreditCardBrand>? CreditCardBrands { get; set; }
        public DbSet<Customer>? Customers { get; set; }
        public DbSet<Infrastructure>? Infrastructures { get; set; }
        public DbSet<PaymentMethod>? PaymentMethods { get; set; }
        public DbSet<Perfil>? Perfils { get; set; }
        public DbSet<PriceQuote>? PriceQuotes { get; set; }
        public DbSet<PriceQuoteAction>? PriceQuoteActions { get; set; }
        public DbSet<PriceQuoteStatus>? PriceQuoteStatus { get; set; }
        public DbSet<Product>? Products { get; set; }
        public DbSet<ProductManufacturer>? ProductManufacturers { get; set; }
        public DbSet<ReasonCancellationPriceQuote>? ReasonsCancellationPriceQuote { get; set; }
        public DbSet<Service>? Services { get; set; }        
        public DbSet<Vehicle>? Vehicles { get; set; }
        public DbSet<VehicleBrand>? VehicleBrands { get; set; }
        public DbSet<VehicleFuel>? VehicleFuels { get; set; }
        public DbSet<VehicleModel>? VehicleModels { get; set; }
        public DbSet<VehicleYear>? VehicleYears { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // modelBuilder.ApplyConfiguration(new CompanyMap());
            base.OnModelCreating(modelBuilder);
            // modelBuilder.ApplyConfigurationsFromAssembly(typeof(CompanyMap).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            foreach (var entityType in modelBuilder.Model.GetEntityTypes())
            {
                entityType.GetForeignKeys()
                    .Where(fk => !fk.IsOwnership && fk.DeleteBehavior == DeleteBehavior.Cascade)
                    .ToList()
                    .ForEach(fk => fk.DeleteBehavior = DeleteBehavior.NoAction);
            }
        }
    }
}

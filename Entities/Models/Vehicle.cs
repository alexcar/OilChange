namespace Entities.Models
{
    public class Vehicle : Entity
    {
        public string? LicencePlate { get; set; }
        public Guid CustomerId { get; set; }
        public Customer? Customer { get; set; }
        public Guid ModelId { get; set; }
        public VehicleModel? Model { get; set; }
        public Guid BrandId { get; set; }
        public VehicleBrand? Brand { get; set; }
        public Guid FuelId { get; set; }
        public VehicleFuel? Fuel { get; set; }
        public Guid YearId { get; set; }
        public VehicleYear? Year { get; set; }
        public ICollection<PriceQuote>? PriceQuotes { get; set; } = new List<PriceQuote>();
    }
}

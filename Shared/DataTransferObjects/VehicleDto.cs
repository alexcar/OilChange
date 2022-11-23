namespace Shared.DataTransferObjects
{
    public record VehicleDto
    {
        public Guid Id { get; set; }
        public string? LicencePlate { get; set; }        
        public Guid ModelId { get; set; }
        public string? Model { get; set; }
        public Guid BrandId { get; set; }
        public string? Brand { get; set; }
        public Guid FuelId { get; set; }
        public string? Fuel { get; set; }
        public Guid YearId { get; set; }
        public string? Year { get; set; }
        public bool Active { get; set; }
    }
}

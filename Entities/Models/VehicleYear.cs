namespace Entities.Models
{
    public class VehicleYear : Entity
    {
        public string? Name { get; set; }
        public ICollection<Vehicle>? Vehicles { get; set; } = new List<Vehicle>();
    }
}

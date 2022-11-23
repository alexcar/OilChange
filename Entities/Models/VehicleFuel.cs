namespace Entities.Models
{
    public class VehicleFuel : Entity
    {
        public string? Name { get; set; }
        public ICollection<Vehicle>? Vehicles { get; set; }
    }
}

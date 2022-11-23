namespace Entities.Models
{
    public class VehicleBrand : Entity
    {
        public string? Name { get; set; }
        public ICollection<Vehicle>? Vehicles { get; set; }
    }
}

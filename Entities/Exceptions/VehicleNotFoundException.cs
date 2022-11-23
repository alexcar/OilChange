namespace Entities.Exceptions
{
    public sealed class VehicleNotFoundException : NotFoundException
    {
        public VehicleNotFoundException(Guid vehicleId) 
            : base($"O veículo com o ID: {vehicleId} não existe.")
        {
        }
    }
}

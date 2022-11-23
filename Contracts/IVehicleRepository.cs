using Entities.Models;

namespace Contracts
{
    public interface IVehicleRepository
    {
        Task<IEnumerable<Vehicle?>> GetAllAsync(bool trackChanges);
        Task<Vehicle?> GetByIdAsync(Guid id, bool trackChanges);
        void CreateVehicle(Vehicle entity);
        void UpdateVehicle(Vehicle entity);
        void DeleteVehicle(Vehicle entity);
    }
}

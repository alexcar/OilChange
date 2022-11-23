using Shared.DataTransferObjects;

namespace Service.Contracts
{
    public interface IVehicleService
    {
        Task<IEnumerable<VehicleDto?>> GetAllAsync(bool trackChanges);
        Task<VehicleDto?> GetByIdAsync(Guid id, bool trackChanges);
        Task<VehicleDto> CreateAsync(VehicleForCreationDto entity);
        Task UpdateAsync(Guid id, VehicleForUpdateDto entity, bool trackChanges);
        Task DeleteAsync(Guid id, bool trackChanges);
    }
}

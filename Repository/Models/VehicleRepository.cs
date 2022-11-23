using Contracts;
using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Repository.Models
{
    internal sealed class VehicleRepository : RepositoryBase<Vehicle>, IVehicleRepository
    {
        public VehicleRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public async Task<IEnumerable<Vehicle?>> GetAllAsync(bool trackChanges) =>
            await FindAll(trackChanges)
                .OrderBy(x => x.Id).ToListAsync();

        public async Task<Vehicle?> GetByIdAsync(Guid id, bool trackChanges) =>
            await FindByCondition(x => x.Id.Equals(id), trackChanges).SingleOrDefaultAsync();

        public new void CreateVehicle(Vehicle entity) => Create(entity);
        public new void UpdateVehicle(Vehicle entity) => Update(entity);
        public new void DeleteVehicle(Vehicle entity) => Delete(entity);        
        
    }
}

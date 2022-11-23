using AutoMapper;
using Contracts;
using Entities.Exceptions;
using Entities.Models;
using Service.Contracts;
using Shared.DataTransferObjects;

namespace Service
{
    internal sealed class VehicleService : IVehicleService
    {
        private readonly IRepositoryManager _repository;
        private readonly IMapper _mapper;

        public VehicleService(IRepositoryManager repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<IEnumerable<VehicleDto?>> GetAllAsync(bool trackChanges)
        {
            var vehicles = await _repository.Vehicle.GetAllAsync(trackChanges);
            var vehiclesDto = _mapper.Map<IEnumerable<VehicleDto?>>(vehicles);

            return vehiclesDto;
        }

        public async Task<VehicleDto?> GetByIdAsync(Guid id, bool trackChanges)
        {
            var vehicle = await _repository.Vehicle.GetByIdAsync(id, trackChanges);

            if (vehicle is null)
                throw new VehicleNotFoundException(id);

            var vehicleDto = _mapper.Map<VehicleDto>(vehicle);

            return vehicleDto;
        }

        public async Task<VehicleDto> CreateAsync(VehicleForCreationDto entity)
        {
            var vehicle = _mapper.Map<Vehicle>(entity);
            
            vehicle.CreationDate = DateTime.Now;

            _repository.Vehicle.CreateVehicle(vehicle);
            await _repository.SaveAsync();

            var vehicleDto = _mapper.Map<VehicleDto>(vehicle);

            return vehicleDto;
        }

        public async Task UpdateAsync(Guid id, VehicleForUpdateDto entity, bool trackChanges)
        {
            var vehicle = await _repository.Vehicle.GetByIdAsync(id, trackChanges);

            if (vehicle is null)
                throw new VehicleNotFoundException(id);

            _mapper.Map(entity, vehicle);            
            await _repository.SaveAsync();            
        }
        
        public async Task DeleteAsync(Guid id, bool trackChanges)
        {
            var vehicle = await _repository.Vehicle.GetByIdAsync(id, trackChanges);

            if (vehicle is null)
                throw new VehicleNotFoundException(id);

            _repository.Vehicle.DeleteVehicle(vehicle);
            await _repository.SaveAsync();
        }
    }
}

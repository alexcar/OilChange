using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Service.Contracts;
using Shared.DataTransferObjects;

namespace TrocaoOleoAPI.Controllers
{
    [Route("api/vehicles")]
    [ApiController]
    [Authorize(Roles = "Administrator, Customer")]
    public class VehiclesController : ControllerBase
    {
        private readonly IServiceManager _service;

        public VehiclesController(IServiceManager service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var vehicles = await _service.VehicleService.GetAllAsync(trackChanges: false);

            return Ok(vehicles);
        }

        [HttpGet("{id:guid}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var vehicle = await _service.VehicleService.GetByIdAsync(id, trackChanges: false);

            return Ok(vehicle);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] VehicleForCreationDto vehicleForCreation)
        {
            var createdVehicle = await _service.VehicleService.CreateAsync(vehicleForCreation);

            return CreatedAtRoute("VehicleById", new { id = createdVehicle.Id }, createdVehicle);
        }        

        [HttpPut("{id:guid}")]
        public async Task<IActionResult> Update(Guid id, [FromBody] VehicleForUpdateDto vehicleForUpdate)
        {
            if (vehicleForUpdate == null)
                return BadRequest("Objeto vehicleForUpdate é null");

            await _service.VehicleService.UpdateAsync(id, vehicleForUpdate, trackChanges: true);

            return NoContent();
        }

        [HttpDelete("{id:guid}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            await _service.VehicleService.DeleteAsync(id, trackChanges: false);

            return NoContent();
        }
    }
}

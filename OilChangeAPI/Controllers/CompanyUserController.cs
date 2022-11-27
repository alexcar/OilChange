using Microsoft.AspNetCore.Mvc;
using Service.Contracts;
using Shared.DataTransferObjects;

namespace OilChangeAPI.Controllers
{
    [Route("api/companyUser")]
    [ApiController]
    public class CompanyUserController : ControllerBase
    {
        private readonly IServiceManager _service;

        public CompanyUserController(IServiceManager service)
        {
            _service = service;
        }

        [HttpPost("CreateUser")]
        public async Task<IActionResult> CreateUser([FromBody] CompanyUserForCreationDto companyUserForCreationDto)
        {
            await _service.CompanyUserService.CreateUserAsync(companyUserForCreationDto);

            return NoContent();
        }
    }
}

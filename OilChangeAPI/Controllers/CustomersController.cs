using EmailService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.Contracts;
using Shared.DataTransferObjects;
using System.Xml.Linq;

namespace TrocaoOleoAPI.Controllers
{
    [Route("api/customers")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly IServiceManager _service;
        private readonly IEmailSender _emailSender;

        public CustomersController(IServiceManager service, IEmailSender emailSender)
        {
            _service = service;
            _emailSender = emailSender;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var customers = await _service.CustomerService.GetAllAsync(trackChanges: false);

            return Ok(customers);
        }

        [HttpGet("{id:guid}", Name = "CustomerById")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var customer = await _service.CustomerService.GetByIdAsync(id, trackChanges: false);

            return Ok(customer);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CustomerForCreationDto customerForCreation)
        {
            var createdCustomer = await _service.CustomerService.CreateAsync(customerForCreation);

            return CreatedAtRoute("CustomerById", new { id = createdCustomer.Id }, createdCustomer);
        }

        [HttpPost("registration")]
        public async Task<IActionResult> CreateRegistration([FromBody] CustomerRegistrationForCreationDto customerRegistration)
        {
            await _service.CustomerService.CreateRegistrationAsync(customerRegistration);            

            return NoContent();
        }

        [HttpPut("{id:guid}")]
        public async Task<IActionResult> Update(Guid id, [FromBody] CustomerForUpdateDto customerForUpdate)
        {
            if (customerForUpdate == null)
                return BadRequest("Objeto customerForUpdate é null");

            await _service.CustomerService.UpdateAsync(id, customerForUpdate, trackChanges: true);

            return NoContent(); 
        }

        [HttpDelete("{id:guid}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            await _service.CustomerService.DeleteAsync(id, trackChanges: false);

            return NoContent();
        }
    }
}

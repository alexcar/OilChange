using AutoMapper;
using Contracts;
using EmailService;
using Entities.Exceptions;
using Entities.Models;
using Microsoft.AspNetCore.Identity;
using Service.Contracts;
using Shared.DataTransferObjects;
using System.Text;

namespace Service
{
    internal sealed class CustomerService : ICustomerService
    {
        private readonly IRepositoryManager _repository;
        private readonly IMapper _mapper;
        private readonly IEmailSender _emailSender;
        private readonly ILoggerManager _logger;
        private readonly UserManager<User> _userManager;

        public CustomerService(
            IRepositoryManager repository,
            IMapper mapper,
            IEmailSender emailSender,
            ILoggerManager logger,
            UserManager<User> userManager)
        {
            _repository = repository;
            _mapper = mapper;
            _emailSender = emailSender;
            _logger = logger;
            _userManager = userManager;
        }
        public async Task<IEnumerable<CustomerDto>> GetAllAsync(bool trackChanges)
        {
            var customers = await _repository.Customer.GetAllAsync(trackChanges);
            var customersDto = _mapper.Map<IEnumerable<CustomerDto>>(customers);

            return customersDto;
        }

        public async Task<CustomerDto?> GetByIdAsync(Guid id, bool trackChanges)
        {
            var customer = await _repository.Customer.GetByIdAsync(id, trackChanges);

            if (customer is null)
                throw new CustomerNotFoundException(id);

            var customerDto = _mapper.Map<CustomerDto>(customer);

            return customerDto;
        }

        public Task<IEnumerable<CustomerDto>> GetByIdsAsync(IEnumerable<Guid> ids, bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public async Task<CustomerDto> CreateAsync(CustomerForCreationDto customer)
        {
            var customerEntity = _mapper.Map<Customer>(customer);
            
            customerEntity.CreationDate = DateTime.Now;

            _repository.Customer.CreateCustomer(customerEntity);
            await _repository.SaveAsync();

            var customerDto = _mapper.Map<CustomerDto>(customerEntity);

            return customerDto;
        }

        public async Task CreateRegistrationAsync(CustomerRegistrationForCreationDto customerRegistration)
        {
            await ValidateFields(customerRegistration);
            InsertCustomerAndCar(customerRegistration);            
            var result = await RegisterUser(customerRegistration);
            
            if (result.Succeeded)
            {
                await _repository.SaveAsync();
                _logger.LogInfo($"Customer {customerRegistration.Name} and vehicle created successfully.");
                await SendEmailToCustomer(customerRegistration);

            } else
            {
                // TODO: Gravar log dos possíveis erros ao incluir/alterar/excluir nas tabelas customer, vehicle, user e roles.
                var errors = new StringBuilder();

                foreach (var error in result.Errors)
                {
                    errors.Append(error.Description);
                }
                
                throw new Exception($"Não foi possível registrar o cliente devido ao(s) seguinte(s) erro(s): {errors.ToString()} ");
            }            
        }

        public Task<(IEnumerable<CustomerDto> customers, string ids)> CreateCollectionAsync(IEnumerable<CustomerForCreationDto> customerCollection)
        {
            throw new NotImplementedException();
        }        

        public async Task UpdateAsync(Guid id, CustomerForUpdateDto customerForUpdate, bool trackChanges)
        {
            var customer = await _repository.Customer.GetByIdAsync(id, trackChanges);

            if (customer is null)
                throw new CustomerNotFoundException(id);

            _mapper.Map(customerForUpdate, customer);
            await _repository.SaveAsync();
        }

        public async Task DeleteAsync(Guid id, bool trackChanges)
        {
            var customer = await _repository.Customer.GetByIdAsync(id, trackChanges);

            if (customer is null)
                throw new CustomerNotFoundException(id);

            _repository.Customer.DeleteCustomer(customer);
            await _repository.SaveAsync();
        }

        public async Task<bool> CpfAlreadyRegistered(string cpf) =>
            await _repository.Customer.CpfAlreadyRegistered(cpf);

        public async Task<bool> EmailAlreadyRegistered(string email) =>
            await _repository.Customer.EmailAlreadyRegistered(email);

        public async Task<bool> LoginAlreadyRegistered(string login) =>
            await _repository.Customer.loginAlreadyRegistered(login);
        
        private async Task ValidateFields(CustomerRegistrationForCreationDto customerRegistration)
        {
            // var cpf = customerRegistration.Cpf!.Replace(".", "").Replace("-", "");
            // TODO: Gravar no banco com o formato 999.999.999-99
            // Se o usuário informar sem ponto e hífen, incluir antes de gravar no banco

            if (await CpfAlreadyRegistered(customerRegistration.Cpf))
            {
                throw new CpfAlreadyRegisteredException(customerRegistration.Cpf);
            }

            if (await EmailAlreadyRegistered(customerRegistration.Email.Trim()))
            {
                throw new EmailAlreadyRegisteredException(customerRegistration.Email.Trim());
            }

            if (await LoginAlreadyRegistered(customerRegistration.Login.Trim()))
                throw new LoginAlreadyRegisteredException(customerRegistration.Login.Trim());
        }

        private void InsertCustomerAndCar(CustomerRegistrationForCreationDto customerRegistration)
        {
            var customer = new Customer()
            {
                Name = customerRegistration.Name,
                Cpf = customerRegistration.Cpf,
                Gender = customerRegistration.Gender,
                Phone = $"{customerRegistration.Ddd} {customerRegistration.Phone}",
                Email = customerRegistration.Email,
                Login = customerRegistration.Login,
                Address = customerRegistration.Address,
                Complement = customerRegistration.Complement,
                Neighborhood = customerRegistration.Neighborhood,
                County = customerRegistration.County,
                Uf = customerRegistration.Uf,
                ZipCode = customerRegistration.Zipcode,
                Country = customerRegistration.Country,
                Active = customerRegistration.Active,
                CreationDate = DateTime.Now
            };

            _repository.Customer.CreateCustomer(customer);

            var vehicle = new Vehicle()
            {
                LicencePlate = customerRegistration.LicencePlate,
                CustomerId = customer.Id,
                ModelId = customerRegistration.ModelId,
                BrandId = customerRegistration.BrandId,
                FuelId = customerRegistration.FuelId,
                YearId = customerRegistration.YearId,
            };

            _repository.Vehicle.CreateVehicle(vehicle);            
        }

        private async Task<IdentityResult> RegisterUser(CustomerRegistrationForCreationDto customerRegistration)
        {
            var userForRegistration = new UserForRegistrationDto()
            {
                FirstName = customerRegistration.Name,
                LastName = customerRegistration.Name,
                UserName = customerRegistration.Login,
                Password = customerRegistration.Password,
                Email = customerRegistration.Email,
                PhoneNumber = $"{customerRegistration.Ddd} {customerRegistration.Phone}",
                Roles = new List<string>
                {
                    "Customer"
                }
            };

            var user = _mapper.Map<User>(userForRegistration);
            var result = await _userManager.CreateAsync(user, userForRegistration.Password);

            if (result.Succeeded)
            {
                await _userManager.AddToRolesAsync(user, userForRegistration.Roles);
            }            

            return result;
        }

        private async Task SendEmailToCustomer(CustomerRegistrationForCreationDto customerRegistration)
        {
            await _emailSender.SendEmail(customerRegistration.Name, customerRegistration.Email, "registration", null, null);
            _logger.LogInfo($"email send to customer {customerRegistration.Name} successfully.");
        }

        public async Task<CustomerDto?> GetByLoginAsync(string login)
        {
            var customer = await _repository.Customer.GetByLoginAsync(login);

            if (customer is null)
                throw new Exception($"Nenhum cliente encontrado com o login: {login}");

            var customerDto = _mapper.Map<CustomerDto>(customer);

            return customerDto;
        }
            
        
    }
}

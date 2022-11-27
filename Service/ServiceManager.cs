using AutoMapper;
using Contracts;
using EmailService;
using Entities.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Service.Contracts;

namespace Service
{
    public sealed class ServiceManager : IServiceManager
    {
        private readonly Lazy<ICompanyService> _companyService;
        private readonly Lazy<IInfrastructureService> _infrastructureService;
        private readonly Lazy<ICreditCardBrandService> _creditCardBrandService;
        private readonly Lazy<IProductManufacturerService> _productManufacturerService;
        private readonly Lazy<IProductService> _productService;
        private readonly Lazy<IAuthenticationService> _authenticationService;
        private readonly Lazy<ICustomerService> _customerService;
        private readonly Lazy<IVehicleService> _vehicleService;
        private readonly Lazy<ICompanyUserService> _companyUserService;

        public ServiceManager(
            IRepositoryManager repositoryManager,            
            IMapper mapper,            
            UserManager<User> userManager,
            IConfiguration configuration,
            IEmailSender emailSender,
            ILoggerManager logger)
        {
            _companyService = new Lazy<ICompanyService>(() =>
                new CompanyService(repositoryManager, mapper));

            _infrastructureService = new Lazy<IInfrastructureService>(() =>
                new InfrastructureService(repositoryManager, mapper));

            _creditCardBrandService = new Lazy<ICreditCardBrandService>(() =>
                new CreditCardBrandService(repositoryManager, mapper));

            _productManufacturerService = new Lazy<IProductManufacturerService>(() =>
                new ProductManufacturerService(repositoryManager, mapper));

            _productService = new Lazy<IProductService>(() =>
                new ProductService(repositoryManager, mapper));

            _authenticationService = new Lazy<IAuthenticationService>(() =>
                new AuthenticationService(repositoryManager, logger, mapper, userManager, configuration));

            _customerService = new Lazy<ICustomerService>(() =>
                new CustomerService(repositoryManager, mapper, emailSender, logger, userManager));

            _vehicleService = new Lazy<IVehicleService>(() => 
                new VehicleService(repositoryManager, mapper));

            _companyUserService = new Lazy<ICompanyUserService>(() =>
                new CompanyUserService(repositoryManager, mapper, logger, userManager));
        }

        public ICompanyService CompanyService => _companyService.Value;
        public IInfrastructureService InfrastructureService => _infrastructureService.Value;
        public ICreditCardBrandService CreditCardBrandService => _creditCardBrandService.Value;
        public IProductManufacturerService ProductManufacturerService => _productManufacturerService.Value;
        public IProductService ProductService => _productService.Value;
        public IAuthenticationService AuthenticationService => _authenticationService.Value;
        public ICustomerService CustomerService => _customerService.Value;
        public IVehicleService VehicleService => _vehicleService.Value;
        public ICompanyUserService CompanyUserService => _companyUserService.Value;
    }
}

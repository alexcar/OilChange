using Contracts;

namespace Repository.Models
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly RepositoryContext _repositoryContext;
        private readonly Lazy<ICompanyRepository> _companyRepository;
        private readonly Lazy<IInfrastructureRepository> _infrastructureRepository;
        private readonly Lazy<ICreditCardBrandRepository> _creditCardBrandRepository;
        private readonly Lazy<IProductManufacturerRepository> _productManufacturerRepository;
        private readonly Lazy<IProductRepository> _productRepository;
        private readonly Lazy<ICustomerRepository> _customerRepository;
        private readonly Lazy<IVehicleRepository> _vehicleRepository;

        public RepositoryManager(RepositoryContext repositoryContext)
        {
            _repositoryContext = repositoryContext;

            _companyRepository = new Lazy<ICompanyRepository>(
                () => new CompanyRepository(repositoryContext));

            _infrastructureRepository = new Lazy<IInfrastructureRepository>(
                () => new InfrastructureRepository(repositoryContext));

            _creditCardBrandRepository = new Lazy<ICreditCardBrandRepository>(
                () => new CreditCardBrandRepository(repositoryContext));

            _productManufacturerRepository = new Lazy<IProductManufacturerRepository>(
                () => new ProductManufacturerRepository(repositoryContext));

            _productRepository = new Lazy<IProductRepository>(
                () => new ProductRepository(repositoryContext));

            _customerRepository = new Lazy<ICustomerRepository>(
                () => new CustomerRepository(repositoryContext));

            _vehicleRepository = new Lazy<IVehicleRepository>(
                () => new VehicleRepository(repositoryContext));
        }

        public ICompanyRepository Company => _companyRepository.Value;
        public IInfrastructureRepository Infrastructure => _infrastructureRepository.Value;
        public ICreditCardBrandRepository CreditCardBrand => _creditCardBrandRepository.Value;
        public IProductManufacturerRepository ProductManufacturer => _productManufacturerRepository.Value;
        public IProductRepository Product => _productRepository.Value;
        public ICustomerRepository Customer => _customerRepository.Value;

        public IVehicleRepository Vehicle => _vehicleRepository.Value;

        public async Task SaveAsync() => await _repositoryContext.SaveChangesAsync();
    }
}

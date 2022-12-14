namespace Service.Contracts
{
    public interface IServiceManager
    {
        ICompanyService CompanyService { get; }
        IInfrastructureService InfrastructureService { get; }
        ICreditCardBrandService CreditCardBrandService { get; }
        IProductManufacturerService ProductManufacturerService { get; }
        IProductService ProductService { get; }
        IAuthenticationService AuthenticationService { get; }
        ICustomerService CustomerService { get; }
        IVehicleService VehicleService { get; }
    }
}

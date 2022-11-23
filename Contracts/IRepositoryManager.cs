namespace Contracts
{
    public interface IRepositoryManager
    {
        ICompanyRepository Company { get; }
        IInfrastructureRepository Infrastructure { get; }
        ICreditCardBrandRepository CreditCardBrand { get; }
        IProductManufacturerRepository ProductManufacturer { get; }
        IProductRepository Product { get; }
        ICustomerRepository Customer { get; }
        IVehicleRepository Vehicle { get; }
        Task SaveAsync();
    }
}

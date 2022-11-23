using Entities.Models;
using Shared.DataTransferObjects;

namespace Service.Contracts
{
    public interface ICustomerService
    {
        Task<IEnumerable<CustomerDto>> GetAllAsync(bool trackChanges);
        Task<CustomerDto?> GetByIdAsync(Guid id, bool trackChanges);
        Task<CustomerDto?> GetByLoginAsync(string login);
        Task<IEnumerable<CustomerDto>> GetByIdsAsync(IEnumerable<Guid> ids, bool trackChanges);
        Task<(IEnumerable<CustomerDto> customers, string ids)> CreateCollectionAsync(
            IEnumerable<CustomerForCreationDto> customerCollection);
        Task<CustomerDto> CreateAsync(CustomerForCreationDto customer);
        Task CreateRegistrationAsync(CustomerRegistrationForCreationDto customerRegistration);
        Task UpdateAsync(Guid id, CustomerForUpdateDto customerForUpdate, bool trackChanges);
        Task DeleteAsync(Guid id, bool trackChanges);
        Task<bool> CpfAlreadyRegistered(string cpf);
        Task<bool> EmailAlreadyRegistered(string email);
        Task<bool> LoginAlreadyRegistered(string login);
    }
}

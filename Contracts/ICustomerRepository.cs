using Entities.Models;

namespace Contracts
{
    public interface ICustomerRepository
    {
        Task<IEnumerable<Customer?>> GetAllAsync(bool trackChanges);
        Task<Customer?> GetByIdAsync(Guid id, bool trackChanges);
        Task<Customer?> GetByLoginAsync(string login);
        Task<IEnumerable<Customer?>> GetByIdsAsync(IEnumerable<Guid> ids, bool trackChanges);
        void CreateCustomer(Customer customer);
        void UpdateCustomer(Customer customer);
        void DeleteCustomer(Customer customer);
        Task<bool> CpfAlreadyRegistered(string cpf);
        Task<bool> EmailAlreadyRegistered(string email);
        Task<bool> loginAlreadyRegistered(string login);
    }
}

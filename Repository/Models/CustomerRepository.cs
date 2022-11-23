using Contracts;
using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Repository.Models
{
    internal sealed class CustomerRepository : RepositoryBase<Customer>, ICustomerRepository
    {
        public CustomerRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public async Task<IEnumerable<Customer?>> GetAllAsync(bool trackChanges) =>
            await FindAll(trackChanges)
                .OrderBy(c => c.Name).ToListAsync();

        public async Task<Customer?> GetByIdAsync(Guid id, bool trackChanges) =>
            await FindByCondition(c => c.Id.Equals(id), trackChanges).SingleOrDefaultAsync();

        public async Task<IEnumerable<Customer?>> GetByIdsAsync(IEnumerable<Guid> ids, bool trackChanges) =>
            await FindByCondition(x => ids.Contains(x.Id), trackChanges).ToListAsync();

        public void CreateCustomer(Customer customer) => Create(customer);

        public void UpdateCustomer(Customer customer) => Update(customer);

        public void DeleteCustomer(Customer customer) => Delete(customer);

        public async Task<bool> CpfAlreadyRegistered(string cpf) =>
            await FindByCondition(x => x.Cpf.Equals(cpf), false).CountAsync() > 0;

        public async Task<bool> EmailAlreadyRegistered(string email) => 
            await FindByCondition(x => x.Email.Equals(email), false).CountAsync() > 0;

        public async Task<bool> loginAlreadyRegistered(string login) =>
            await FindByCondition(x => x.Login.Equals(login), false).CountAsync() > 0;

        public async Task<Customer?> GetByLoginAsync(string login) =>
            await FindByCondition(x => x.Login.Equals(login), false).SingleOrDefaultAsync();
    }
}

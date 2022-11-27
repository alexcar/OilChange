using Contracts;
using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Repository.Models
{
    internal sealed class CompanyUserRepository : RepositoryBase<CompanyUser>, ICompanyUserRepository
    {
        public CompanyUserRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public void CreateUser(CompanyUser companyUser) => Create(companyUser);

        public async Task<CompanyUser?> GetByLoginAsync(string login) =>
            await FindByCondition(x => x.Login.Equals(login), false).SingleOrDefaultAsync();        

        public async Task<bool> EmailAlreadyRegistered(string email) => 
            await FindByCondition(x => x.Email.Equals(email), false).CountAsync() > 0;        

        public async Task<bool> loginAlreadyRegistered(string login) =>
            await FindByCondition(x => x.Login.Equals(login), false).CountAsync() > 0;        
    }
}

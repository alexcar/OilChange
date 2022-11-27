using Entities.Models;

namespace Contracts
{
    public interface ICompanyUserRepository
    {
        Task<CompanyUser?> GetByLoginAsync(string login);
        void CreateUser(CompanyUser companyUser);
        Task<bool> EmailAlreadyRegistered(string email);
        Task<bool> loginAlreadyRegistered(string login);
    }
}

using Shared.DataTransferObjects;

namespace Service.Contracts
{
    public interface ICompanyUserService
    {
        Task CreateUserAsync(CompanyUserForCreationDto companyUserDto);
    }
}

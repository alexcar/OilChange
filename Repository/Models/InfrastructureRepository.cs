using Contracts;
using Entities.Models;

namespace Repository.Models
{
    internal sealed class InfrastructureRepository : RepositoryBase<Infrastructure>, IInfrastructureRepository
    {
        public InfrastructureRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}

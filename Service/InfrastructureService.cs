using AutoMapper;
using Contracts;
using Service.Contracts;

namespace Service
{
    internal sealed class InfrastructureService : IInfrastructureService
    {
        private readonly IRepositoryManager _repository;
        // private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public InfrastructureService(
            IRepositoryManager repository,
            IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
    }
}

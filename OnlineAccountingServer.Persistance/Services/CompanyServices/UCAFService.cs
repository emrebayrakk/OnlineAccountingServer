using AutoMapper;
using OnlineAccountingServer.Application.Features.CompanyFeatures.UCAFFeatures.Commands.CreateUCAF;
using OnlineAccountingServer.Application.Services.CompanyService;
using OnlineAccountingServer.Domain;
using OnlineAccountingServer.Domain.CompanyEntities;
using OnlineAccountingServer.Domain.Repositories.CompanyDbContext.UCAFRepositories;
using OnlineAccountingServer.Domain.UoWs;
using OnlineAccountingServer.Persistance.Context;

namespace OnlineAccountingServer.Persistance.Services.CompanyServices
{
    public sealed class UCAFService : IUCAFService
    {
        private readonly IUCAFCommandRepository _commandRepository;
        private readonly IUCAFQueryRepository _ucafQueryRepository;
        private readonly IContextService _contextService;
        private readonly ICompanyUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private CompanyDbContext _context;
        public UCAFService(IUCAFCommandRepository commandRepository, IContextService contextService, ICompanyUnitOfWork unitOfWork, IMapper mapper, IUCAFQueryRepository ucafQueryRepository)
        {
            _commandRepository = commandRepository;
            _contextService = contextService;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _ucafQueryRepository = ucafQueryRepository;
        }

        public async Task CreateUcafAsync(CreateUCAFCommand request, CancellationToken cancellationToken)
        {
            _context = (CompanyDbContext)_contextService.CreateDbContextInstance(request.CompanyId);
            _commandRepository.SetDbContextInstance(_context);
            _unitOfWork.SetDbContextInstance(_context);

            var req = _mapper.Map<UniformChartOfAccount>(request);
            req.Id = Guid.NewGuid().ToString();
            await _commandRepository.AddAsync(req, cancellationToken);
            await _unitOfWork.SaveChangesAsync(cancellationToken);
        }

        public async Task<UniformChartOfAccount> GetByCode(string Code)
        {
            return await _ucafQueryRepository.GetFirstByExpression(a => a.Code == Code);
        }
    }
}

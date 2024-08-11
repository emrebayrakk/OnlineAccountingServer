using AutoMapper;
using Microsoft.EntityFrameworkCore;
using OnlineAccountingServer.Application.Features.AppFeatures.CompanyFeatures.Commands.CreateCompany;
using OnlineAccountingServer.Application.Services.AppService;
using OnlineAccountingServer.Domain.AppEntities;
using OnlineAccountingServer.Domain.Repositories.AppDbContext.CompanyRepositories;
using OnlineAccountingServer.Domain.UoWs;
using OnlineAccountingServer.Persistance.Context;

namespace OnlineAccountingServer.Persistance.Services.AppServices
{
    public sealed class CompanyService : ICompanyService
    {
        private readonly ICompanyCommandRepository _companyCommandRepository;
        private readonly ICompanyQueryRepository _companyQueryRepository;
        private readonly IAppUnitOfWork _appUnitOfWork;
        private readonly IMapper _mapper;

        public CompanyService(IMapper mapper, ICompanyCommandRepository companyCommandRepository, ICompanyQueryRepository companyQueryRepository, IAppUnitOfWork appUnitOfWork)
        {
            _mapper = mapper;
            _companyCommandRepository = companyCommandRepository;
            _companyQueryRepository = companyQueryRepository;
            _appUnitOfWork = appUnitOfWork;
        }

        public async Task CreateCompany(CreateCompanyCommand request, CancellationToken cancellationToken)
        {
            Company company = _mapper.Map<Company>(request);
            company.Id = Guid.NewGuid().ToString();
            await _companyCommandRepository.AddAsync(company,cancellationToken);
            await _appUnitOfWork.SaveChangesAsync(cancellationToken);
        }

        public IQueryable<Company> GetAll()
        {
            return _companyQueryRepository.GetAll();
        }

        public async Task<Company?> GetCompanyByName(string name)
        {
            return await _companyQueryRepository.GetFirstByExpression(a=>a.Name == name);
        }

        public async Task MigrateCompanyDatabases()
        {
            var companies = await _companyQueryRepository.GetAll().ToListAsync();
            foreach (var item in companies)
            {
                var db = new CompanyDbContext(item);
                db.Database.Migrate();
            }
        }
    }
}

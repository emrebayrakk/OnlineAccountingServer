using AutoMapper;
using Microsoft.EntityFrameworkCore;
using OnlineAccountingServer.Application.Features.AppFeatures.CompanyFeatures.Commands.CreateCompany;
using OnlineAccountingServer.Application.Services.AppService;
using OnlineAccountingServer.Domain.AppEntities;
using OnlineAccountingServer.Persistance.Context;

namespace OnlineAccountingServer.Persistance.Services.AppServices
{
    public sealed class CompanyService : ICompanyService
    {

        private static readonly Func<AppDbContext, string, Task<Company?>> 
            GetCompanyByNameCompiled = 
            EF.CompileAsyncQuery((AppDbContext context, string name) => 
            context.Set<Company>().FirstOrDefault(a => a.Name == name)
            );
        private readonly AppDbContext _appDbContext;
        private readonly IMapper _mapper;

        public CompanyService(AppDbContext appDbContext, IMapper mapper)
        {
            _appDbContext = appDbContext;
            _mapper = mapper;
        }

        public async Task CreateCompany(CreateCompanyCommand request, CancellationToken cancellationToken)
        {
            Company company = _mapper.Map<Company>(request);
            company.Id = Guid.NewGuid().ToString();
            await _appDbContext.Set<Company>().AddAsync(company,cancellationToken);
            await _appDbContext.SaveChangesAsync(cancellationToken);
        }

        public async Task<Company?> GetCompanyByName(string name)
        {
            return await GetCompanyByNameCompiled(_appDbContext, name);
        }

        public async Task MigrateCompanyDatabases()
        {
            var companies = await _appDbContext.Set<Company>().ToListAsync();
            foreach (var item in companies)
            {
                var db = new CompanyDbContext(item);
                db.Database.Migrate();
            }
        }
    }
}

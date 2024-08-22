using OnlineAccountingServer.Application.Features.AppFeatures.CompanyFeatures.Commands.CreateCompany;
using OnlineAccountingServer.Domain.AppEntities;

namespace OnlineAccountingServer.Application.Services.AppServices
{
    public interface ICompanyService
    {
        Task CreateCompany(CreateCompanyCommand request, CancellationToken cancellationToken);
        Task MigrateCompanyDatabases();
        Task<Company?> GetCompanyByName(string name);
        IQueryable<Company> GetAll();
    }
}

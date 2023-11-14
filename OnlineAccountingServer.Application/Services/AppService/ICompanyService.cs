using OnlineAccountingServer.Application.Features.AppFeatures.CompanyFeatures.Commands.CreateCompany;
using OnlineAccountingServer.Domain.AppEntities;

namespace OnlineAccountingServer.Application.Services.AppService
{
    public interface ICompanyService
    {
        Task CreateCompany(CreateCompanyCommand request);
        Task MigrateCompanyDatabases();
        Task<Company?> GetCompanyByName(string name); 
    }
}

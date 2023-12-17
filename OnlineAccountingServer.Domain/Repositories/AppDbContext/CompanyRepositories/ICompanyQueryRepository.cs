using OnlineAccountingServer.Domain.AppEntities;
using OnlineAccountingServer.Domain.Repositories.GenericRepositories.AppDbContext;

namespace OnlineAccountingServer.Domain.Repositories.AppDbContext.CompanyRepositories
{
    public interface ICompanyQueryRepository : IAppQueryRepository<Company>
    {
    }
}

using OnlineAccountingServer.Domain.AppEntities;
using OnlineAccountingServer.Domain.Repositories.AppDbContext.CompanyRepositories;
using OnlineAccountingServer.Persistance.Repositories.GenericRepositories.AppDbContext;

namespace OnlineAccountingServer.Persistance.Repositories.AppDbContext.CompanyRepositories
{
    public class CompanyQueryRepository : AppQueryRepository<Company>, ICompanyQueryRepository
    {
        public CompanyQueryRepository(Context.AppDbContext context) : base(context)
        {
        }
    }
}

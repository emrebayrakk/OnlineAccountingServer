using Microsoft.EntityFrameworkCore;
using OnlineAccountingServer.Domain.AppEntities;
using OnlineAccountingServer.Domain.Repositories.AppDbContext.CompanyRepositories;
using OnlineAccountingServer.Persistance.Repositories.GenericRepositories.AppDbContext;

namespace OnlineAccountingServer.Persistance.Repositories.AppDbContext.CompanyRepositories
{
    public class CompanyCommandRepository : AppCommandRepository<Company>, ICompanyCommandRepository
    {
        public CompanyCommandRepository(Context.AppDbContext context) : base(context)
        {
        }
    }
}

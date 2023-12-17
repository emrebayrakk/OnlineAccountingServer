using OnlineAccountingServer.Domain.Abstraction;

namespace OnlineAccountingServer.Domain.Repositories.GenericRepositories.CompanyDbContext
{
    public interface ICompanyQueryRepository<T> : ICompanyRepository<T>, IQueryGenericRepository<T> where T : Entity
    {
        
    }
}

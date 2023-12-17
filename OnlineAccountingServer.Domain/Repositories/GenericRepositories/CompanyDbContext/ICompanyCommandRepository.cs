using OnlineAccountingServer.Domain.Abstraction;

namespace OnlineAccountingServer.Domain.Repositories.GenericRepositories.CompanyDbContext
{
    public interface ICompanyCommandRepository<T> : ICompanyRepository<T>, ICommandGenericRepository<T> where T : Entity
    {
    }
}

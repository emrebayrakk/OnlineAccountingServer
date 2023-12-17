using OnlineAccountingServer.Domain.Abstraction;

namespace OnlineAccountingServer.Domain.Repositories.GenericRepositories.AppDbContext;

public interface IAppQueryRepository<T> : IQueryGenericRepository<T> where T : Entity
{
}

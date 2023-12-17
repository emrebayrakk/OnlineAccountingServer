using Microsoft.EntityFrameworkCore;
using OnlineAccountingServer.Domain.Abstraction;

namespace OnlineAccountingServer.Domain.Repositories.GenericRepositories.AppDbContext
{
    public interface IAppCommandRepository<T>: ICommandGenericRepository<T> where T : Entity
    {
    }
}

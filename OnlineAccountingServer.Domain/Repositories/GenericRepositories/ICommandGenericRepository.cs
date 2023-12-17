using Microsoft.EntityFrameworkCore;
using OnlineAccountingServer.Domain.Abstraction;

namespace OnlineAccountingServer.Domain.Repositories.GenericRepositories
{
    public interface ICommandGenericRepository<T> where T : Entity
    {
        DbSet<T> Entity { get; set; }
        Task AddAsync(T entity, CancellationToken cancellationToken);
        Task AddRangeAsync(IEnumerable<T> entities, CancellationToken cancellationToken);
        void Update(T entity);
        void UpdateRange(IEnumerable<T> entities);
        Task RemoveById(string id);
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entities);
    }
}

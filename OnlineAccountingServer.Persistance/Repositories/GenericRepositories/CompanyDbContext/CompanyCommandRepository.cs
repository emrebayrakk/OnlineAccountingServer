using Microsoft.EntityFrameworkCore;
using OnlineAccountingServer.Domain.Abstraction;
using OnlineAccountingServer.Domain.Repositories.GenericRepositories.CompanyDbContext;

namespace OnlineAccountingServer.Persistance.Repositories.GenericRepositories.CompanyDbContext
{
    public class CompanyCommandRepository<T> : ICompanyCommandRepository<T> where T : Entity
    {
        private Context.CompanyDbContext _context;
        private static readonly Func<Context.CompanyDbContext, string, Task<T>> GetById =
            EF.CompileAsyncQuery((Context.CompanyDbContext context, string id) =>
            context.Set<T>().FirstOrDefault(a => a.Id == id));

        public DbSet<T> Entity { get; set; }

        public void SetDbContextInstance(DbContext dbContext)
        {
            _context = (Context.CompanyDbContext)dbContext;
            Entity = _context.Set<T>();
        }
        public async Task AddAsync(T entity, CancellationToken cancellationToken)
        {
            await Entity.AddAsync(entity, cancellationToken);
        }

        public async Task AddRangeAsync(IEnumerable<T> entities, CancellationToken cancellationToken)
        {
            await Entity.AddRangeAsync(entities, cancellationToken);
        }


        public void Remove(T entity)
        {
            Entity.Remove(entity);
        }

        public async Task RemoveById(string id)
        {
            T entity = await GetById(_context, id);
        }

        public void RemoveRange(IEnumerable<T> entities)
        {
            Entity.RemoveRange(entities);
        }

        public void Update(T entity)
        {
            Entity.Update(entity);
        }

        public void UpdateRange(IEnumerable<T> entities)
        {
            Entity.UpdateRange(entities);
        }
    }
}

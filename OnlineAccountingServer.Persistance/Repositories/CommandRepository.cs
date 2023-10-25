using Microsoft.EntityFrameworkCore;
using OnlineAccountingServer.Domain.Abstraction;
using OnlineAccountingServer.Domain.Repositories;
using OnlineAccountingServer.Persistance.Context;

namespace OnlineAccountingServer.Persistance.Repositories
{
    public class CommandRepository<T> : ICommandRepository<T> where T : Entity
    {
        private CompanyDbContext _context;
        private static readonly Func<CompanyDbContext, string, Task<T>> GetById =
            EF.CompileAsyncQuery((CompanyDbContext context, string id) =>
            context.Set<T>().FirstOrDefault(a => a.Id == id));

        public DbSet<T> Entity { get; set; }

        public void SetDbContextInstance(DbContext dbContext)
        {
            _context = (CompanyDbContext)dbContext;
            Entity = _context.Set<T>();
        }
        public async Task AddAsync(T entity)
        {
            await Entity.AddAsync(entity);
        }

        public async Task AddRangeAsync(IEnumerable<T> entities)
        {
            await Entity.AddRangeAsync(entities);
        }


        public void Remove(T entity)
        {
            Entity.Remove(entity);
        }

        public async Task RemoveById(string id)
        {
            T entity = await GetById(_context,id);
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

using Microsoft.EntityFrameworkCore;
using OnlineAccountingServer.Domain.Abstraction;
using System.Linq.Expressions;

namespace OnlineAccountingServer.Domain.Repositories.GenericRepositories
{
    public interface IQueryGenericRepository<T> where T : Entity
    {
        public DbSet<T> Entity { get; set; }
        IQueryable<T> GetAll(bool isTracking = true);
        IQueryable<T> GetWhere(Expression<Func<T, bool>> expression, bool isTracking = true);
        Task<T> GetById(string id, bool isTracking = true);
        Task<T> GetFirstByExpression(Expression<Func<T, bool>> expression, bool isTracking = true);
        Task<T> GetFirst(bool isTracking = true);
    }
}

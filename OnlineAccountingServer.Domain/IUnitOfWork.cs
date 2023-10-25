using Microsoft.EntityFrameworkCore;

namespace OnlineAccountingServer.Domain
{
    public interface IUnitOfWork
    {
        void SetDbContextInstance(DbContext dbContext);
        Task<int> SaveChangesAsync();
    }
}

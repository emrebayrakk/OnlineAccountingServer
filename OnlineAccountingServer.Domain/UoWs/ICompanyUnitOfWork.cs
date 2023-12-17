using Microsoft.EntityFrameworkCore;

namespace OnlineAccountingServer.Domain.UoWs
{
    public interface ICompanyUnitOfWork : IUnitOfWork
    {
        void SetDbContextInstance(DbContext dbContext);
    }
}

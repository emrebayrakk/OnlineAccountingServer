using Microsoft.EntityFrameworkCore;
using OnlineAccountingServer.Domain.UoWs;
using OnlineAccountingServer.Persistance.Context;

namespace OnlineAccountingServer.Persistance.UoWs
{
    public sealed class CompanyUnitOfWork : ICompanyUnitOfWork
    {
        private CompanyDbContext _context;

        public void SetDbContextInstance(DbContext dbContext)
        {
            _context = (CompanyDbContext)dbContext;
        }

        public async Task<int> SaveChangesAsync(CancellationToken cancellationToken)
        {
            int count = await _context.SaveChangesAsync(cancellationToken);
            return count;
        }
    }
}

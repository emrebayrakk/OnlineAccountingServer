using Microsoft.EntityFrameworkCore;
using OnlineAccountingServer.Domain.Abstraction;

namespace OnlineAccountingServer.Domain.Repositories.GenericRepositories.CompanyDbContext
{
    public interface ICompanyRepository<T> where T : Entity
    {
        void SetDbContextInstance(DbContext dbContext);
    }
}

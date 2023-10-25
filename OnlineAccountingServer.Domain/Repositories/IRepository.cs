using Microsoft.EntityFrameworkCore;
using OnlineAccountingServer.Domain.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineAccountingServer.Domain.Repositories
{
    public interface IRepository<T> where T : Entity
    {
        void SetDbContextInstance(DbContext dbContext);
        DbSet<T> Entity { get; set; }
    }
}

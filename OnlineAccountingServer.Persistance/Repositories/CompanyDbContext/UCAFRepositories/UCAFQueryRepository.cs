using OnlineAccountingServer.Domain.CompanyEntities;
using OnlineAccountingServer.Domain.Repositories.CompanyDbContext.UCAFRepositories;
using OnlineAccountingServer.Persistance.Repositories.GenericRepositories.CompanyDbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineAccountingServer.Persistance.Repositories.CompanyDbContext.UCAFRepositories
{
    public sealed class UCAFQueryRepository : CompanyQueryRepository<UniformChartOfAccount>, IUCAFQueryRepository
    {
    }
}

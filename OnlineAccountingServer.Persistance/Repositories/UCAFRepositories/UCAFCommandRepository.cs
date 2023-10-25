using OnlineAccountingServer.Domain.CompanyEntities;
using OnlineAccountingServer.Domain.Repositories.UCAFRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineAccountingServer.Persistance.Repositories.UCAFRepositories
{
    public sealed class UCAFCommandRepository : CommandRepository<UniformChartOfAccount> , IUCAFCommandRepository
    {
    }
}

using OnlineAccountingServer.Domain.CompanyEntities;
using OnlineAccountingServer.Domain.Repositories.GenericRepositories.CompanyDbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineAccountingServer.Domain.Repositories.CompanyDbContext.UCAFRepositories
{
    public interface IUCAFCommandRepository : ICompanyCommandRepository<UniformChartOfAccount>
    {
    }
}

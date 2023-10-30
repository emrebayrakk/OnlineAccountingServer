using OnlineAccountingServer.Application.Services.AppService;
using OnlineAccountingServer.Application.Services.CompanyService;
using OnlineAccountingServer.Domain.Repositories.UCAFRepositories;
using OnlineAccountingServer.Domain;
using OnlineAccountingServer.Persistance.Repositories.UCAFRepositories;
using OnlineAccountingServer.Persistance.Services.AppServices;
using OnlineAccountingServer.Persistance.Services.CompanyServices;
using OnlineAccountingServer.Persistance;

namespace OnlineAccountingServer.WebApi.Configurations
{
    public class PersistanceDIServiceInstaller : IServiceInstaller
    {
        public void Install(IServiceCollection services, IConfiguration configuration)
        {
            #region Context UoW
            services.AddScoped<IContextService, ContextService>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            #endregion

            #region Services
            services.AddScoped<IUCAFService, UCAFService>();
            services.AddScoped<ICompanyService, CompanyService>();
            #endregion

            #region Repositories
            services.AddScoped<IUCAFCommandRepository, UCAFCommandRepository>();
            services.AddScoped<IUCAFQueryRepository, UCAFQueryRepository>();
            #endregion


        }
    }
}

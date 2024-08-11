using OnlineAccountingServer.Application.Services.AppService;
using OnlineAccountingServer.Application.Services.CompanyService;
using OnlineAccountingServer.Domain;
using OnlineAccountingServer.Persistance.Services.AppServices;
using OnlineAccountingServer.Persistance.Services.CompanyServices;
using OnlineAccountingServer.Persistance;
using OnlineAccountingServer.Domain.Repositories.CompanyDbContext.UCAFRepositories;
using OnlineAccountingServer.Persistance.Repositories.CompanyDbContext.UCAFRepositories;
using OnlineAccountingServer.Domain.Repositories.AppDbContext.CompanyRepositories;
using OnlineAccountingServer.Persistance.Repositories.AppDbContext.CompanyRepositories;
using OnlineAccountingServer.Domain.UoWs;
using OnlineAccountingServer.Persistance.UoWs;
using OnlineAccountingServer.Domain.Repositories.AppDbContext.MainRoleRepositories;
using OnlineAccountingServer.Persistance.Repositories.AppDbContext.MainRoleRepositories;

namespace OnlineAccountingServer.WebApi.Configurations
{
    public class PersistanceDIServiceInstaller : IServiceInstaller
    {
        public void Install(IServiceCollection services, IConfiguration configuration)
        {
            #region Context UoW
            services.AddScoped<IContextService, ContextService>();
            services.AddScoped<IAppUnitOfWork, AppUnitOfWork>();
            services.AddScoped<ICompanyUnitOfWork, CompanyUnitOfWork>();
            #endregion

            #region Services
            services.AddScoped<IUCAFService, UCAFService>();
            services.AddScoped<ICompanyService, CompanyService>();
            services.AddScoped<IRoleService, RoleService>();
            services.AddScoped<IMainRoleService, MainRoleService>();
            #endregion

            #region Repositories
            services.AddScoped<IUCAFCommandRepository, UCAFCommandRepository>();
            services.AddScoped<IUCAFQueryRepository, UCAFQueryRepository>();

            services.AddScoped<ICompanyCommandRepository, CompanyCommandRepository>();
            services.AddScoped<ICompanyQueryRepository, CompanyQueryRepository>();

            services.AddScoped<IMainRoleCommandRepository, MainRoleCommandRepository>();
            services.AddScoped<IMainRoleQueryRepository, MainRoleQueryRepository>();
            #endregion


        }
    }
}

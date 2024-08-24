using OnlineAccountingServer.Application.Services.AppServices;
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
using OnlineAccountingServer.Domain.Repositories.AppDbContext.MainRoleAndUserRelationshipRepositories;
using OnlineAccountingServer.Persistance.Repositories.AppDbContext.MainRoleAndUserRelationshipRepositories;
using OnlineAccountingServer.Domain.Repositories.AppDbContext.UserAndCompanyRelationshipRepositories;
using OnlineAccountingServer.Persistance.Repositories.AppDbContext.UserAndCompanyRelationshipRepositories;
using OnlineAccountingServer.Domain.Repositories.AppDbContext.MainRoleAndRoleRelationshipRepositories;
using OnlineAccountingServer.Persistance.Repositories.AppDbContext.MainRoleAndRoleRelationshipRepositories;
//UsingSpot


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
                #region CompanyDbContext
                services.AddScoped<IUCAFService, UCAFService>();
                //CompanyServiceDISpot
                #endregion


                #region AppDbContext
                services.AddScoped<ICompanyService, CompanyService>();
                services.AddScoped<IRoleService, RoleService>();
                services.AddScoped<IMainRoleService, MainRoleService>();
                services.AddScoped<IMainRoleAndUserRelationshipService, MainRoleAndUserRelationshipService>();
                services.AddScoped<IUserAndCompanyRelationshipService, UserAndCompanyRelationshipService>();
                services.AddScoped<IMainRoleAndRoleRelationshipService, MainRoleAndRoleRelationshipService>();
                services.AddScoped<IAuthService, AuthService>();
                //AppServiceDISpot
                #endregion
            #endregion

            #region Repositories
                #region CompanyDbContext
                services.AddScoped<IUCAFCommandRepository, UCAFCommandRepository>();
                services.AddScoped<IUCAFQueryRepository, UCAFQueryRepository>();
                //CompanyRepositoryDISpot
                #endregion

                #region AppDbContext
                services.AddScoped<ICompanyCommandRepository, CompanyCommandRepository>();
                services.AddScoped<ICompanyQueryRepository, CompanyQueryRepository>();

                services.AddScoped<IMainRoleCommandRepository, MainRoleCommandRepository>();
                services.AddScoped<IMainRoleQueryRepository, MainRoleQueryRepository>();
                services.AddScoped<IMainRoleAndUserRelationshipCommandRepository, MainRoleAndUserRelationshipCommandRepository>();
                services.AddScoped<IMainRoleAndUserRelationshipQueryRepository, MainRoleAndUserRelationshipQueryRepository>();
                services.AddScoped<IUserAndCompanyRelationshipCommandRepository, UserAndCompanyRelationshipCommandRepository>();
                services.AddScoped<IUserAndCompanyRelationshipQueryRepository, UserAndCompanyRelationshipQueryRepository>();
                services.AddScoped<IMainRoleAndRoleRelationshipCommandRepository, MainRoleAndRoleRelationshipCommandRepository>();
                services.AddScoped<IMainRoleAndRoleRelationshipQueryRepository, MainRoleAndRoleRelationshipQueryRepository>();
                //AppRepositoryDISpot
                #endregion

            #endregion



        }
    }
}

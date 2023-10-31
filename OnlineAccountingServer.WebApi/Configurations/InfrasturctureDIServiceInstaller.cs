using OnlineAccountingServer.Application.Abstractions;
using OnlineAccountingServer.Infrasturcture.Authentication;

namespace OnlineAccountingServer.WebApi.Configurations
{
    public class InfrasturctureDIServiceInstaller : IServiceInstaller
    {
        public void Install(IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IJwtProvider,JwtProvider>();
        }
    }
}

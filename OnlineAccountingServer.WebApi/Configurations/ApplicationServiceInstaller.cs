using MediatR;

namespace OnlineAccountingServer.WebApi.Configurations
{
    public class ApplicationServiceInstaller : IServiceInstaller
    {
        public void Install(IServiceCollection services, IConfiguration configuration)
        {
            services.AddMediatR(typeof(OnlineAccountingServer.Application.AssemblyReference).Assembly);
        }
    }
}

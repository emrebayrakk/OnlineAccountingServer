using FluentValidation;
using MediatR;
using OnlineAccountingServer.Application;
using OnlineAccountingServer.Application.Behavior;

namespace OnlineAccountingServer.WebApi.Configurations
{
    public class ApplicationServiceInstaller : IServiceInstaller
    {
        public void Install(IServiceCollection services, IConfiguration configuration)
        {
            services.AddMediatR(typeof(OnlineAccountingServer.Application.AssemblyReference).Assembly);
            services.AddTransient(typeof(IPipelineBehavior<,>),
                (typeof(ValidationBehavior<,>)));

            services.AddValidatorsFromAssembly(typeof(OnlineAccountingServer.Application.AssemblyReference).Assembly);
        }
    }
}

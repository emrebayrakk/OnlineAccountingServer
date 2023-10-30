using Microsoft.EntityFrameworkCore;
using OnlineAccountingServer.Domain.AppEntities.Identity;
using OnlineAccountingServer.Persistance.Context;

namespace OnlineAccountingServer.WebApi.Configurations
{
    public class PersistanceServiceInstaller : IServiceInstaller
    {
        private const string SectionName = "SqlServer";
        public void Install(IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString(SectionName)));
            services.AddIdentity<AppUser, AppRole>().AddEntityFrameworkStores<AppDbContext>();
            services.AddAutoMapper(typeof(OnlineAccountingServer.Persistance.AssemblyReference).Assembly);

        }
    }
}

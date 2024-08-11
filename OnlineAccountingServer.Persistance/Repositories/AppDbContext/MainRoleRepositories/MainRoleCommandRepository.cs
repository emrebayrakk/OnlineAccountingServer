using OnlineAccountingServer.Domain.AppEntities;
using OnlineAccountingServer.Domain.Repositories.AppDbContext.MainRoleRepositories;
using OnlineAccountingServer.Persistance.Repositories.GenericRepositories.AppDbContext;

namespace OnlineAccountingServer.Persistance.Repositories.AppDbContext.MainRoleRepositories
{
    public sealed class MainRoleCommandRepository : AppCommandRepository<MainRole>, IMainRoleCommandRepository
    {
        public MainRoleCommandRepository(Context.AppDbContext context) : base(context)
        {
        }
    }
}

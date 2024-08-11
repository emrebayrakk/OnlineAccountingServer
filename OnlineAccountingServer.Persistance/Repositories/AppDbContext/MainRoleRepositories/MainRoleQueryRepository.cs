using OnlineAccountingServer.Domain.AppEntities;
using OnlineAccountingServer.Domain.Repositories.AppDbContext.MainRoleRepositories;
using OnlineAccountingServer.Persistance.Repositories.GenericRepositories.AppDbContext;

namespace OnlineAccountingServer.Persistance.Repositories.AppDbContext.MainRoleRepositories
{
    public sealed class MainRoleQueryRepository : AppQueryRepository<MainRole>, IMainRoleQueryRepository
    {
        public MainRoleQueryRepository(Context.AppDbContext context) : base(context)
        {
        }
    }
}

using OnlineAccountingServer.Domain.AppEntities;
using OnlineAccountingServer.Persistance.Repositories.GenericRepositories.AppDbContext;
using OnlineAccountingServer.Domain.Repositories.AppDbContext.MainRoleAndUserRelationshipRepositories;

namespace OnlineAccountingServer.Persistance.Repositories.AppDbContext.MainRoleAndUserRelationshipRepositories;

public class MainRoleAndUserRelationshipCommandRepository : AppCommandRepository<MainRoleAndUserRelationship>, IMainRoleAndUserRelationshipCommandRepository
{
    public MainRoleAndUserRelationshipCommandRepository(Persistance.Context.AppDbContext context) : base(context){ }
}

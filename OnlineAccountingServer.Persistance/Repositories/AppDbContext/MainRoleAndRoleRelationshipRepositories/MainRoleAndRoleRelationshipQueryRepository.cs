using OnlineAccountingServer.Domain.AppEntities;
using OnlineAccountingServer.Persistance.Repositories.GenericRepositories.AppDbContext;
using OnlineAccountingServer.Domain.Repositories.AppDbContext.MainRoleAndRoleRelationshipRepositories;

namespace OnlineAccountingServer.Persistance.Repositories.AppDbContext.MainRoleAndRoleRelationshipRepositories;

public class MainRoleAndRoleRelationshipQueryRepository : AppQueryRepository<MainRoleAndRoleRelationship>, IMainRoleAndRoleRelationshipQueryRepository
{
    public MainRoleAndRoleRelationshipQueryRepository(Persistance.Context.AppDbContext context) : base(context){ }
}

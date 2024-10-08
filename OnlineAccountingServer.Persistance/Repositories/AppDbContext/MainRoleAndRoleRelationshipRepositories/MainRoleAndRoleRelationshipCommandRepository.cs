using OnlineAccountingServer.Domain.AppEntities;
using OnlineAccountingServer.Persistance.Repositories.GenericRepositories.AppDbContext;
using OnlineAccountingServer.Domain.Repositories.AppDbContext.MainRoleAndRoleRelationshipRepositories;

namespace OnlineAccountingServer.Persistance.Repositories.AppDbContext.MainRoleAndRoleRelationshipRepositories;

public class MainRoleAndRoleRelationshipCommandRepository : AppCommandRepository<MainRoleAndRoleRelationship>, IMainRoleAndRoleRelationshipCommandRepository
{
    public MainRoleAndRoleRelationshipCommandRepository(Persistance.Context.AppDbContext context) : base(context){ }
}

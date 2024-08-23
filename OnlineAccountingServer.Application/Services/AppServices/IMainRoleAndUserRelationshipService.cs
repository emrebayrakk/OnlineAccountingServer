using OnlineAccountingServer.Domain.AppEntities;

namespace OnlineAccountingServer.Application.Services.AppServices;

public interface IMainRoleAndUserRelationshipService
{
    Task CreateAsync(MainRoleAndUserRelationship mainRoleAndUserRelationship, CancellationToken cancellationToken);
    Task RemoveByIdAsync(string id);
    Task<MainRoleAndUserRelationship> GetByUserIdCompanyIdAndMainRoleId(string userId, string companyId, string mainRoleId);
    Task<MainRoleAndUserRelationship> GetById(string id);
}

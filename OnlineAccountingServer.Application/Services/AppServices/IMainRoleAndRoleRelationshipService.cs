using OnlineAccountingServer.Domain.AppEntities;

namespace OnlineAccountingServer.Application.Services.AppServices;

public interface IMainRoleAndRoleRelationshipService
{
    Task CreateAsync(MainRoleAndRoleRelationship mainRoleAndRoleRelationship,CancellationToken cancellationToken);
    Task UpdateAsync(MainRoleAndRoleRelationship mainRoleAndRoleRelationship);
    Task RemoveById(string id);
    IQueryable<MainRoleAndRoleRelationship> GetAll();
    Task<MainRoleAndRoleRelationship> GetById(string id);
    Task<bool> AnyRoleIdAndMainRoleId(string roleId, string mainRoleId , CancellationToken cancellationToken = default);
}

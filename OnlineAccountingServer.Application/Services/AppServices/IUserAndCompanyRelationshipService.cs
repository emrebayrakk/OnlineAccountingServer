using OnlineAccountingServer.Domain.AppEntities;

namespace OnlineAccountingServer.Application.Services.AppServices;

public interface IUserAndCompanyRelationshipService
{
    Task CreateAsync(UserAndCompanyRelationship userAndCompanyRelationship, CancellationToken cancellationToken);
    Task RemoveByIdAsync(string id);
    Task<UserAndCompanyRelationship> GetByIdAsync(string id);
    Task<UserAndCompanyRelationship> GetByUserIdAndCompanyId(string userId, string companyId);
}

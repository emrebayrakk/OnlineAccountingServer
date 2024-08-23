using OnlineAccountingServer.Application.Services.AppServices;
using OnlineAccountingServer.Domain.AppEntities;
using OnlineAccountingServer.Domain.Repositories.AppDbContext.UserAndCompanyRelationshipRepositories;
using OnlineAccountingServer.Domain.UoWs;

namespace OnlineAccountingServer.Persistance.Services.AppServices;

public class UserAndCompanyRelationshipService : IUserAndCompanyRelationshipService
{
    private readonly IUserAndCompanyRelationshipCommandRepository _commandRepository;
    private readonly IUserAndCompanyRelationshipQueryRepository _queryRepository;
    private readonly IAppUnitOfWork _unitOfWork;

    public UserAndCompanyRelationshipService(IUserAndCompanyRelationshipCommandRepository commandRepository, IUserAndCompanyRelationshipQueryRepository queryRepository, IAppUnitOfWork unitOfWork)
    {
        _commandRepository = commandRepository;
        _queryRepository = queryRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task CreateAsync(UserAndCompanyRelationship userAndCompanyRelationship, CancellationToken cancellationToken)
    {
        await _commandRepository.AddAsync(userAndCompanyRelationship,cancellationToken);
        await _unitOfWork.SaveChangesAsync(cancellationToken);
    }

    public async Task<UserAndCompanyRelationship> GetByIdAsync(string id)
    {
        return await _queryRepository.GetById(id);
    }

    public async Task<UserAndCompanyRelationship> GetByUserIdAndCompanyId(string userId, string companyId)
    {

        return await _queryRepository.GetFirstByExpression(a => a.AppUserId == userId && a.CompanyId == companyId);
    }

    public async Task RemoveByIdAsync(string id)
    {
        await _commandRepository.RemoveById(id);
        await _unitOfWork.SaveChangesAsync();
    }
}

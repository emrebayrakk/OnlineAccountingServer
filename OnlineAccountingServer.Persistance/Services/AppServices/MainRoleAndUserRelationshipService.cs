using OnlineAccountingServer.Application.Services.AppServices;
using OnlineAccountingServer.Domain.AppEntities;
using OnlineAccountingServer.Domain.Repositories.AppDbContext.MainRoleAndUserRelationshipRepositories;
using OnlineAccountingServer.Domain.UoWs;

namespace OnlineAccountingServer.Persistance.Services.AppServices;

public class MainRoleAndUserRelationshipService : IMainRoleAndUserRelationshipService
{
    private readonly IMainRoleAndUserRelationshipCommandRepository _mainRoleAndUserRelationshipCommandRepository;
    private readonly IMainRoleAndUserRelationshipQueryRepository _mainRoleAndUserRelationshipQueryRepository;
    private readonly IAppUnitOfWork _appUnitOfWork;
    public MainRoleAndUserRelationshipService(IMainRoleAndUserRelationshipQueryRepository mainRoleAndUserRelationshipQueryRepository, IMainRoleAndUserRelationshipCommandRepository mainRoleAndUserRelationshipCommandRepository, IAppUnitOfWork appUnitOfWork)
    {
        _mainRoleAndUserRelationshipQueryRepository = mainRoleAndUserRelationshipQueryRepository;
        _mainRoleAndUserRelationshipCommandRepository = mainRoleAndUserRelationshipCommandRepository;
        _appUnitOfWork = appUnitOfWork;
    }

    public async Task CreateAsync(MainRoleAndUserRelationship mainRoleAndUserRelationship, CancellationToken cancellationToken)
    {
        await _mainRoleAndUserRelationshipCommandRepository.AddAsync(mainRoleAndUserRelationship, cancellationToken);
        await _appUnitOfWork.SaveChangesAsync(cancellationToken);
    }

    public async Task<MainRoleAndUserRelationship> GetById(string id)
    {
        return await _mainRoleAndUserRelationshipQueryRepository.GetById(id);
    }

    public async Task<MainRoleAndUserRelationship> GetByUserIdCompanyIdAndMainRoleId(string userId, string companyId, string mainRoleId , CancellationToken cancellationToken)
    {
        return await _mainRoleAndUserRelationshipQueryRepository.GetFirstByExpression(a =>
        a.UserId == userId && a.CompanyId == companyId && a.MainRoleId == mainRoleId, cancellationToken);
    }

    public async Task<MainRoleAndUserRelationship> GetRolesByUserIdAndCompanyId(string userId, string companyId)
    {
        return await _mainRoleAndUserRelationshipQueryRepository.GetFirstByExpression(a => a.UserId == userId && a.CompanyId == companyId,default);
    }

    public async Task RemoveByIdAsync(string id)
    {
        await _mainRoleAndUserRelationshipCommandRepository.RemoveById(id);
        await _appUnitOfWork.SaveChangesAsync();
    }
}

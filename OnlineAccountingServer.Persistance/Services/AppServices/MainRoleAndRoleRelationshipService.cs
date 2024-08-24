using Microsoft.EntityFrameworkCore;
using OnlineAccountingServer.Application.Services.AppServices;
using OnlineAccountingServer.Domain.AppEntities;
using OnlineAccountingServer.Domain.Repositories.AppDbContext.MainRoleAndRoleRelationshipRepositories;
using OnlineAccountingServer.Domain.UoWs;
using System.Threading;

namespace OnlineAccountingServer.Persistance.Services.AppServices;

public class MainRoleAndRoleRelationshipService : IMainRoleAndRoleRelationshipService
{
    private readonly IMainRoleAndRoleRelationshipCommandRepository _commandRepository;
    private readonly IMainRoleAndRoleRelationshipQueryRepository _queryRepository;
    private readonly IAppUnitOfWork _appUnitOfWork;

    public MainRoleAndRoleRelationshipService(IMainRoleAndRoleRelationshipQueryRepository queryRepository, IMainRoleAndRoleRelationshipCommandRepository commandRepository, IAppUnitOfWork appUnitOfWork)
    {
        _queryRepository = queryRepository;
        _commandRepository = commandRepository;
        _appUnitOfWork = appUnitOfWork;
    }

    public async Task CreateAsync(MainRoleAndRoleRelationship mainRoleAndRoleRelationship, CancellationToken cancellationToken)
    {
        await _commandRepository.AddAsync(mainRoleAndRoleRelationship,cancellationToken);
        await _appUnitOfWork.SaveChangesAsync(cancellationToken);
    }

    public IQueryable<MainRoleAndRoleRelationship> GetAll()
    {
        return _queryRepository.GetAll();
    }

    public async Task<MainRoleAndRoleRelationship> GetByIdAsync(string id)
    {
        return await _queryRepository.GetById(id);
    }

    public async Task<bool> AnyRoleIdAndMainRoleId(string roleId, string mainRoleId, CancellationToken cancellationToken = default)
    {
        var item = await _queryRepository.GetFirstByExpression(a => a.RoleId == roleId && a.MainRoleId == mainRoleId , cancellationToken);
        if (item == null)
            return false;
        return true;
    }

    public async Task RemoveById(string id)
    {
        await _commandRepository.RemoveById(id);
        await _appUnitOfWork.SaveChangesAsync();
    }

    public async Task UpdateAsync(MainRoleAndRoleRelationship mainRoleAndRoleRelationship)
    {
        _commandRepository.Update(mainRoleAndRoleRelationship);
        await _appUnitOfWork.SaveChangesAsync();
    }

    public async Task<IList<MainRoleAndRoleRelationship>> GetByMainRoleIdForGetRolesAsync(string id)
    {
        return await _queryRepository.GetWhere(a => a.MainRoleId == id).Include("AppRole").ToListAsync();
    }
}

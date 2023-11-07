﻿using OnlineAccountingServer.Application.Features.RoleFeature.Commands.CreateRole;
using OnlineAccountingServer.Application.Features.RoleFeature.Commands.UpdateRole;
using OnlineAccountingServer.Domain.AppEntities.Identity;

namespace OnlineAccountingServer.Application.Services.AppService
{
    public interface IRoleService
    {
        Task AddAsync(CreateRoleRequest request);
        Task UpdateAsync(AppRole appRole);
        Task DeleteAsync(AppRole appRole);
        Task<IList<AppRole>> GetAllRoleAsync();
        Task<AppRole> GetById(string id);
        Task<AppRole> GetByCode(string code);
    }
}

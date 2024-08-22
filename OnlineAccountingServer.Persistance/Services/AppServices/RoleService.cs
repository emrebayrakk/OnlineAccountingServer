using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using OnlineAccountingServer.Application.Features.RoleFeature.Commands.CreateRole;
using OnlineAccountingServer.Application.Services.AppServices;
using OnlineAccountingServer.Domain.AppEntities.Identity;

namespace OnlineAccountingServer.Persistance.Services.AppServices
{
    public sealed class RoleService : IRoleService
    {
        private readonly RoleManager<AppRole> _roleManager;
        private readonly IMapper _mapper;

        public RoleService(RoleManager<AppRole> roleManager, IMapper mapper)
        {
            _roleManager = roleManager;
            _mapper = mapper;
        }

        public async Task AddAsync(CreateRoleCommand request)
        {
            var role = _mapper.Map<AppRole>(request);
            role.Id = Guid.NewGuid().ToString();
            await _roleManager.CreateAsync(role);
        }

        public async Task AddRangeAsync(IEnumerable<AppRole> roles)
        {
            foreach (var item in roles)
            {
                await _roleManager.CreateAsync(item);
            }
            
        }

        public async Task DeleteAsync(AppRole appRole)
        {
            await _roleManager.DeleteAsync(appRole);
        }

        public async Task<IList<AppRole>> GetAllRoleAsync()
        {
            IList<AppRole> roles = await _roleManager.Roles.ToListAsync();
            return roles;
        }

        public async Task<AppRole> GetByCode(string code)
        {
            var role = await _roleManager.Roles.FirstOrDefaultAsync(x => x.Code == code);
            return role;
        }

        public async Task<AppRole> GetById(string id)
        {
            var role = await _roleManager.Roles.FirstOrDefaultAsync(x => x.Id == id);
            return role;
        }

        public async Task UpdateAsync(AppRole appRole)
        {
            await _roleManager.UpdateAsync(appRole);
        }
    }
}

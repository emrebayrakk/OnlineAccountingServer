using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using OnlineAccountingServer.Application.Services.AppServices;
using OnlineAccountingServer.Domain.AppEntities;
using OnlineAccountingServer.Domain.AppEntities.Identity;

namespace OnlineAccountingServer.Persistance.Services.AppServices
{
    public class AuthService : IAuthService
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly IUserAndCompanyRelationshipService _userAndCompanyRelationshipService;
        private readonly IMainRoleAndUserRelationshipService _mainRoleAndUserRelationshipService;
        private readonly IMainRoleAndRoleRelationshipService _mainRoleAndRoleRelationshipService;

        public AuthService(UserManager<AppUser> userManager, 
            IUserAndCompanyRelationshipService userAndCompanyRelationshipService, 
            IMainRoleAndUserRelationshipService mainRoleAndUserRelationshipService,
            IMainRoleAndRoleRelationshipService mainRoleAndRoleRelationshipService)
        {
            _userManager = userManager;
            _userAndCompanyRelationshipService = userAndCompanyRelationshipService;
            _mainRoleAndUserRelationshipService = mainRoleAndUserRelationshipService;
            _mainRoleAndRoleRelationshipService = mainRoleAndRoleRelationshipService;
        }

        public async Task<bool> CheckPasswordAsync(AppUser user, string password)
        {
           return await _userManager.CheckPasswordAsync(user, password);
        }

        public async Task<AppUser> GetByEmailOrUserNameAsync(string emailOrUserName)
        {
            return await _userManager.Users.Where(a => a.Email == emailOrUserName 
            || a.UserName == emailOrUserName).FirstOrDefaultAsync();
        }

        public Task<IList<UserAndCompanyRelationship>> GetCompanyListByUserIdAsync(string userId)
        {
            return _userAndCompanyRelationshipService.GetCompanyListByUserIdAsync(userId);
        }

        public async Task<IList<string>> GetRolesByUserIdAndCompanyId(string userId, string companyId)
        {
            MainRoleAndUserRelationship mainRoleAndUserRelationship = await _mainRoleAndUserRelationshipService.GetRolesByUserIdAndCompanyId(userId, companyId);

            IList<MainRoleAndRoleRelationship> getMainRole = await
                _mainRoleAndRoleRelationshipService.GetByMainRoleIdForGetRolesAsync(mainRoleAndUserRelationship.MainRoleId);

            IList<string> roles = getMainRole.Select(s => s.AppRole.Name).ToList();

            return roles;
        }
    }
}

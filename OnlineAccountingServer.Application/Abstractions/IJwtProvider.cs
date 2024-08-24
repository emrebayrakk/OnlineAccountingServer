using OnlineAccountingServer.Domain.AppEntities.Identity;
using OnlineAccountingServer.Domain.Dtos;

namespace OnlineAccountingServer.Application.Abstractions
{
    public interface IJwtProvider
    {
        Task<TokenRefreshTokenDto> CreateTokenAsync(AppUser user);
    }
}

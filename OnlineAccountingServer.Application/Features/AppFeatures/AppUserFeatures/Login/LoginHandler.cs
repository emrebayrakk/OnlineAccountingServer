using MediatR;
using Microsoft.AspNetCore.Identity;
using OnlineAccountingServer.Application.Abstractions;
using OnlineAccountingServer.Domain.AppEntities.Identity;

namespace OnlineAccountingServer.Application.Features.AppFeatures.AppUserFeatures.Login
{
    public class LoginHandler : IRequestHandler<LoginRequest, LoginResponse>
    {
        private readonly IJwtProvider _jwtProvider;
        private readonly UserManager<AppUser> _userManager;

        public LoginHandler(IJwtProvider jwtProvider, UserManager<AppUser> userManager)
        {
            _jwtProvider = jwtProvider;
            _userManager = userManager;
        }

        public async Task<LoginResponse> Handle(LoginRequest request, CancellationToken cancellationToken)
        {
            var user = _userManager.Users.Where(a => a.Email == request.EmailOrUserName || a.UserName == request.EmailOrUserName).FirstOrDefault();
            if (user == null) throw new Exception("User Not Found!");

            var checkUser = await _userManager.CheckPasswordAsync(user, request.Password);
            if (!checkUser) throw new Exception("Password Is Wrong!");

            List<string> roles = new();
            LoginResponse response = new()
            {
                Email = user.Email,
                NameLastName = user.NameLastName,
                UserId = user.Id,
                Token = await _jwtProvider.CreateTokenAsync(user, roles)
            };
            return response;
        }
    }
}

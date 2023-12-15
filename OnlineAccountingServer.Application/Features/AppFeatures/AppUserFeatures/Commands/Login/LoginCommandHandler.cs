using MediatR;
using Microsoft.AspNetCore.Identity;
using OnlineAccountingServer.Application.Abstractions;
using OnlineAccountingServer.Application.Messaging;
using OnlineAccountingServer.Domain.AppEntities.Identity;

namespace OnlineAccountingServer.Application.Features.AppFeatures.AppUserFeatures.Commands.Login
{
    public class LoginCommandHandler : ICommandHandler<LoginCommand, LoginCommandResponse>
    {
        private readonly IJwtProvider _jwtProvider;
        private readonly UserManager<AppUser> _userManager;

        public LoginCommandHandler(IJwtProvider jwtProvider, UserManager<AppUser> userManager)
        {
            _jwtProvider = jwtProvider;
            _userManager = userManager;
        }

        public async Task<LoginCommandResponse> Handle(LoginCommand request, CancellationToken cancellationToken)
        {
            var user = _userManager.Users.Where(a => a.Email == request.EmailOrUserName || a.UserName == request.EmailOrUserName).FirstOrDefault();
            if (user == null) throw new Exception("User Not Found!");

            var checkUser = await _userManager.CheckPasswordAsync(user, request.Password);
            if (!checkUser) throw new Exception("Password Is Wrong!");

            List<string> roles = new();
            LoginCommandResponse response = new(
                user.Email,
                user.Id,
                user.NameLastName,
                await _jwtProvider.CreateTokenAsync(user, roles));
            return response;
        }
    }
}

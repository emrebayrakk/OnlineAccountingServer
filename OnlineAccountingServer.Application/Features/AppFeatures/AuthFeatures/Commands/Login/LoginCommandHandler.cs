using Microsoft.AspNetCore.Identity;
using OnlineAccountingServer.Application.Abstractions;
using OnlineAccountingServer.Application.Messaging;
using OnlineAccountingServer.Application.Services.AppServices;
using OnlineAccountingServer.Domain.AppEntities;
using OnlineAccountingServer.Domain.AppEntities.Identity;
using OnlineAccountingServer.Domain.Dtos;

namespace OnlineAccountingServer.Application.Features.AppFeatures.AuthFeatures.Commands.Login
{
    public class LoginCommandHandler : ICommandHandler<LoginCommand, LoginCommandResponse>
    {
        private readonly IJwtProvider _jwtProvider;
        private readonly UserManager<AppUser> _userManager;
        private readonly IAuthService _authService;

        public LoginCommandHandler(IJwtProvider jwtProvider, UserManager<AppUser> userManager, IAuthService authService)
        {
            _jwtProvider = jwtProvider;
            _userManager = userManager;
            _authService = authService;
        }

        public async Task<LoginCommandResponse> Handle(LoginCommand request, CancellationToken cancellationToken)
        {
            AppUser user = await _authService.GetByEmailOrUserNameAsync(request.EmailOrUserName);
            if (user == null) throw new Exception("User Not Found!");

            var checkUser = await _authService.CheckPasswordAsync(user, request.Password);
            if (!checkUser) throw new Exception("Password Is Wrong!");

            IList<UserAndCompanyRelationship> companies = await _authService.GetCompanyListByUserIdAsync(user.Id);
            if (companies.Count() == 0) throw new Exception("Error!");

            IList<CompanyDto> companyDtos = companies.Select(s => new CompanyDto
            (
                s.Company.Id,
                s.Company.Name
            )).ToList();

            LoginCommandResponse response = new(
                Token: await _jwtProvider.CreateTokenAsync(user),
                Email: user.Email,
                UserId: user.Id,
                NameLastName: user.NameLastName,
                Companies: companyDtos,
                Company: companyDtos[0]
                );
            return response;
        }
    }
}

using Microsoft.AspNetCore.Identity;
using OnlineAccountingServer.Application.Messaging;
using OnlineAccountingServer.Domain.AppEntities.Identity;

namespace OnlineAccountingServer.Application.Features.AppFeatures.AppUserFeatures.Commands.Register
{
    public sealed class RegisterCommandHandler : ICommandHandler<RegisterCommand, RegisterCommandResponse>
    {
        private readonly UserManager<AppUser> _userManager;

        public RegisterCommandHandler(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        public async Task<RegisterCommandResponse> Handle(RegisterCommand request, CancellationToken cancellationToken)
        {
            var user = _userManager.Users.Where(a => a.Email == request.email).FirstOrDefault();
            if (user != null) throw new Exception("user already exists!");

            var userAdd = new AppUser
            {
                UserName = request.userName,
                Email = request.email,
                Id = Guid.NewGuid().ToString(),
                NameLastName = request.nameLastName,
            };
            _userManager.CreateAsync(userAdd, request.password).Wait();
            RegisterCommandResponse response = new();

            return response;
        }
    }
}

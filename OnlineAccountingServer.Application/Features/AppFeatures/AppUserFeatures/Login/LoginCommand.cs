using MediatR;
using OnlineAccountingServer.Application.Messaging;

namespace OnlineAccountingServer.Application.Features.AppFeatures.AppUserFeatures.Login
{
    public sealed record LoginCommand(string EmailOrUserName,
        string Password) : ICommand<LoginCommandResponse>;
}

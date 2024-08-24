using OnlineAccountingServer.Application.Messaging;

namespace OnlineAccountingServer.Application.Features.AppFeatures.AuthFeatures.Commands.Login
{
    public sealed record LoginCommand(string EmailOrUserName,
        string Password) : ICommand<LoginCommandResponse>;
}

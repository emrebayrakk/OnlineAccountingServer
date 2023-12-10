using OnlineAccountingServer.Application.Messaging;

namespace OnlineAccountingServer.Application.Features.AppFeatures.AppUserFeatures.Commands.Register
{
    public sealed record RegisterCommand(
        string userName,
        string email,
        string nameLastName,
        string password) : ICommand<RegisterCommandResponse>;
}

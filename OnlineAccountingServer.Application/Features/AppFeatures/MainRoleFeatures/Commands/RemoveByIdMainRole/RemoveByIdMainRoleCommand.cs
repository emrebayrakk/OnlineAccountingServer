using OnlineAccountingServer.Application.Messaging;

namespace OnlineAccountingServer.Application.Features.AppFeatures.MainRoleFeatures.Commands.RemoveByIdMainRole
{
    public sealed record RemoveByIdMainRoleCommand(
       string Id) : ICommand<RemoveByIdMainRoleCommandResponse>;
}

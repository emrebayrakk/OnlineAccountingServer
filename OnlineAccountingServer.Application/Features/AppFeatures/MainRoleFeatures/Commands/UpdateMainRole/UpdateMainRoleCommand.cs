using OnlineAccountingServer.Application.Messaging;

namespace OnlineAccountingServer.Application.Features.AppFeatures.MainRoleFeatures.Commands.UpdateMainRole
{
    public sealed record UpdateMainRoleCommand(
     string Id,
     string Title) : ICommand<UpdateMainRoleCommandResponse>;
}

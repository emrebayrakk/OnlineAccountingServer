using OnlineAccountingServer.Application.Messaging;

namespace OnlineAccountingServer.Application.Features.RoleFeature.Commands.UpdateRole
{
    public sealed record UpdateRoleCommand(
        string Id,
        string Code,
        string Name) : ICommand<UpdateRoleCommandResponse>;
}

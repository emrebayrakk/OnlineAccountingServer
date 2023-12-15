using OnlineAccountingServer.Application.Messaging;

namespace OnlineAccountingServer.Application.Features.RoleFeature.Commands.CreateAllRoles
{
    public sealed record CreateAllRolesCommand() : ICommand<CreateAllRolesCommandResponse>;
}

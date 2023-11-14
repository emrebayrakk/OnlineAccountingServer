using OnlineAccountingServer.Application.Messaging;

namespace OnlineAccountingServer.Application.Features.RoleFeature.Commands.DeleteRole
{
    public sealed record DeleteRoleCommand(string Id) : ICommand<DeleteRoleCommandResponse>;
    
}

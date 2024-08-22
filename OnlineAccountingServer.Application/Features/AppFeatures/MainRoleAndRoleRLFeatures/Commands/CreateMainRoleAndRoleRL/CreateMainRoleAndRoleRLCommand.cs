using OnlineAccountingServer.Application.Messaging;

namespace OnlineAccountingServer.Application.Features.AppFeatures.MainRoleAndRoleRLFeatures.Commands.CreateMainRoleAndRoleRL
{
    public sealed record CreateMainRoleAndRoleRLCommand(
        string RoleId,
        string MainRoleId) : ICommand<CreateMainRoleAndRoleRLCommandResponse>;
}

using OnlineAccountingServer.Application.Messaging;
using OnlineAccountingServer.Domain.AppEntities;

namespace OnlineAccountingServer.Application.Features.AppFeatures.MainRoleFeaatures.Commands.CreateStaticMainRoles
{
    public sealed record CreateStaticMainRolesCommand(List<MainRole> MainRoles) : ICommand<CreateStaticMainRolesCommandResponse>;
}

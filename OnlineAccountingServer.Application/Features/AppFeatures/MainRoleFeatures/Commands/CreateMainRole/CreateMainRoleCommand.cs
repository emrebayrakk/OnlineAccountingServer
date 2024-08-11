using OnlineAccountingServer.Application.Features.AppFeatures.MainRoleFeaatures.Commands.CreateMainRole;
using OnlineAccountingServer.Application.Messaging;

namespace OnlineAccountingServer.Application.Features.AppFeatures.MainRoleFeaatures.Commands.CreateRole
{
    public sealed record CreateMainRoleCommand(
        string Title,
        string CompanyId = null
        ) : ICommand<CreateMainRoleResponse>;
}

using OnlineAccountingServer.Application.Messaging;

namespace OnlineAccountingServer.Application.Features.AppFeatures.MainRoleAndUserRLFeatures.Commands.CreateMainRoleAndUserRL
{
    public sealed record CreateMainRoleAndUserRLCommand(
        string userId,
        string mainRoleId,
        string companyId) : 
        ICommand<CreateMainRoleAndUserRLCommandResponse>;
}

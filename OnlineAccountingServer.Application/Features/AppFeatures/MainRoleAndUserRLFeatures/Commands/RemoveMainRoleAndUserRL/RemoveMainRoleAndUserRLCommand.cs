using OnlineAccountingServer.Application.Messaging;

namespace OnlineAccountingServer.Application.Features.AppFeatures.MainRoleAndUserRLFeatures.Commands.RemoveMainRoleAndUserRL
{
    public sealed record RemoveMainRoleAndUserRLCommand(string id) 
        : ICommand<RemoveMainRoleAndUserRLCommandResponse>;
}

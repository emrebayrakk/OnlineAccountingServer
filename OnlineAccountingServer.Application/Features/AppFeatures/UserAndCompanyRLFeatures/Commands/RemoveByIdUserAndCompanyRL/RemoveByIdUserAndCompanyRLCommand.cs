using OnlineAccountingServer.Application.Messaging;

namespace OnlineAccountingServer.Application.Features.AppFeatures.UserAndCompanyRLFeatures.Commands.RemoveByIdUserAndCompanyRL
{
    public sealed record RemoveByIdUserAndCompanyRLCommand(
        string Id) : 
        ICommand<RemoveByIdUserAndCompanyRLCommandResponse>;
}

using MediatR;
using OnlineAccountingServer.Application.Messaging;
using System.Windows.Input;

namespace OnlineAccountingServer.Application.Features.CompanyFeatures.UCAFFeatures.Commands.CreateUCAF
{
    public sealed record CreateUCAFCommand(
        string Code,
        string Name,
        char Type,
        string CompanyId) : ICommand<CreateUCAFCommandResponse>;
}

using MediatR;

namespace OnlineAccountingServer.Application.Messaging
{
    public interface ICommandHandler<in TCommand, TResponse> : IRequestHandler<TCommand,TResponse>
        where TCommand : ICommand<TResponse>
    {
    }
}

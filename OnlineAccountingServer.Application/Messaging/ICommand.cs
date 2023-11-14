using MediatR;

namespace OnlineAccountingServer.Application.Messaging
{
    public interface ICommand<out TResponse>  : IRequest<TResponse>
    {
    }
}

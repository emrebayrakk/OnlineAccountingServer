using MediatR;

namespace OnlineAccountingServer.Application.Messaging
{
    public interface IQuery<out TResponse> : IRequest<TResponse>
    {
    }
}

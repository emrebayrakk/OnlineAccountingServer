using MediatR;
using OnlineAccountingServer.Presentation.Abstraction; 

namespace OnlineAccountingServer.Presentation.Controller;

public class MainRoleAndUserRelationshipsController : ApiController
{
    public MainRoleAndUserRelationshipsController(IMediator mediator) : base(mediator) {}
}

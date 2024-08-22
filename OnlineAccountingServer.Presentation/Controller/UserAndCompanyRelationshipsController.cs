using MediatR;
using OnlineAccountingServer.Presentation.Abstraction; 

namespace OnlineAccountingServer.Presentation.Controller;

public class UserAndCompanyRelationshipsController : ApiController
{
    public UserAndCompanyRelationshipsController(IMediator mediator) : base(mediator) {}
}

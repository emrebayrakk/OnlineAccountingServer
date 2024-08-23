using MediatR;
using Microsoft.AspNetCore.Mvc;
using OnlineAccountingServer.Application.Features.AppFeatures.UserAndCompanyRLFeatures.Commands.CreateUserAndCompanyRL;
using OnlineAccountingServer.Application.Features.AppFeatures.UserAndCompanyRLFeatures.Commands.RemoveByIdUserAndCompanyRL;
using OnlineAccountingServer.Presentation.Abstraction; 

namespace OnlineAccountingServer.Presentation.Controller;

public class UserAndCompanyRelationshipsController : ApiController
{
    public UserAndCompanyRelationshipsController(IMediator mediator) : base(mediator) {}

    [HttpPost("[action]")]
    public async Task<IActionResult> Create(CreateUserAndCompanyRLCommand request ,CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(request, cancellationToken);
        return Ok(response);
    }
    [HttpDelete("[action]")]
    public async Task<IActionResult> Remove(RemoveByIdUserAndCompanyRLCommand request)
    {
        var response = await _mediator.Send(request);
        return Ok(response);
    }
}

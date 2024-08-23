using MediatR;
using Microsoft.AspNetCore.Mvc;
using OnlineAccountingServer.Application.Features.AppFeatures.MainRoleAndUserRLFeatures.Commands.CreateMainRoleAndUserRL;
using OnlineAccountingServer.Application.Features.AppFeatures.MainRoleAndUserRLFeatures.Commands.RemoveMainRoleAndUserRL;
using OnlineAccountingServer.Presentation.Abstraction;

namespace OnlineAccountingServer.Presentation.Controller;

public class MainRoleAndUserRelationshipsController : ApiController
{
    public MainRoleAndUserRelationshipsController(IMediator mediator) : base(mediator) {}

    [HttpPost("[action]")]
    public async Task<IActionResult> Create(CreateMainRoleAndUserRLCommand request, CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(request, cancellationToken);
        return Ok(response);
    }
    [HttpDelete("[action]")]
    public async Task<IActionResult> Remove(RemoveMainRoleAndUserRLCommand request)
    {
        var response = await _mediator.Send(request);
        return Ok(response);
    }
}

using MediatR;
using Microsoft.AspNetCore.Mvc;
using OnlineAccountingServer.Application.Features.AppFeatures.MainRoleAndRoleRLFeatures.Commands.CreateMainRoleAndRoleRL;
using OnlineAccountingServer.Application.Features.AppFeatures.MainRoleAndRoleRLFeatures.Commands.RemoveByIdMainRoleAndRoleRL;
using OnlineAccountingServer.Application.Features.AppFeatures.MainRoleAndRoleRLFeatures.Queries;
using OnlineAccountingServer.Presentation.Abstraction;

namespace OnlineAccountingServer.Presentation.Controller;

public class MainRoleAndRoleRelationshipsController : ApiController
{
    public MainRoleAndRoleRelationshipsController(IMediator mediator) : base(mediator) {}

    [HttpPost("[action]")]
    public async Task<IActionResult> Create(CreateMainRoleAndRoleRLCommand request, CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(request, cancellationToken);
        return Ok(response);

    }
    [HttpGet("[action]")]
    public async Task<IActionResult> GetAll()
    {
        GetAllMainRoleAndRoleRLQuery request = new();
        var response = await _mediator.Send(request);
        return Ok(response);

    }
    [HttpDelete("[action]")]
    public async Task<IActionResult> RemoveById(RemoveByIdMainRoleAndRoleRLCommand request)
    {
        var response = await _mediator.Send(request);
        return Ok(response);

    }
}

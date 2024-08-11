using MediatR;
using Microsoft.AspNetCore.Mvc;
using OnlineAccountingServer.Application.Features.AppFeatures.MainRoleFeaatures.Commands.CreateMainRole;
using OnlineAccountingServer.Application.Features.AppFeatures.MainRoleFeaatures.Commands.CreateRole;
using OnlineAccountingServer.Application.Features.AppFeatures.MainRoleFeaatures.Commands.CreateStaticMainRoles;
using OnlineAccountingServer.Application.Features.AppFeatures.MainRoleFeaatures.Queries.GetAllMainRole;
using OnlineAccountingServer.Application.Features.AppFeatures.MainRoleFeatures.Commands.RemoveByIdMainRole;
using OnlineAccountingServer.Application.Features.AppFeatures.MainRoleFeatures.Commands.UpdateMainRole;
using OnlineAccountingServer.Presentation.Abstraction;

namespace OnlineAccountingServer.Presentation.Controller
{
    public class MainRolesController : ApiController
    {
        public MainRolesController(IMediator mediator) : base(mediator)
        {
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> CreateMainRole(CreateMainRoleCommand request, CancellationToken cancellationToken)
        {
            CreateMainRoleResponse response = await _mediator.Send(request, cancellationToken);
            return Ok(response);
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> CreateStaticMainRole(CancellationToken cancellationToken)
        {
            CreateStaticMainRolesCommand request = new(null);
            CreateStaticMainRolesCommandResponse response = await _mediator.Send(request, cancellationToken);
            return Ok(response);
        }
        [HttpGet("[action]")]
        public async Task<IActionResult> GetAllMainRoles()
        {
            GetAllMainRoleQuery request = new();
            GetAllMainRoleQueryResponse response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> RemoveById(RemoveByIdMainRoleCommand request)
        {
            RemoveByIdMainRoleCommandResponse response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Update(UpdateMainRoleCommand request)
        {
            UpdateMainRoleCommandResponse response = await _mediator.Send(request);
            return Ok(response);
        }
    }
}

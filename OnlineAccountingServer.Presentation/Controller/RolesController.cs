using MediatR;
using Microsoft.AspNetCore.Mvc;
using OnlineAccountingServer.Application.Features.RoleFeature.Commands.CreateRole;
using OnlineAccountingServer.Application.Features.RoleFeature.Commands.DeleteRole;
using OnlineAccountingServer.Application.Features.RoleFeature.Commands.UpdateRole;
using OnlineAccountingServer.Application.Features.RoleFeature.Queries.GetAllRoles;
using OnlineAccountingServer.Presentation.Abstraction;

namespace OnlineAccountingServer.Presentation.Controller
{
    public class RolesController : ApiController
    {
        public RolesController(IMediator mediator) : base(mediator)
        {
        }
        [HttpPost("[action]")]
        public async Task<IActionResult> CreateRole(CreateRoleRequest request)
        {
            var response = await _mediator.Send(request);
            return Ok(response);
        }
        [HttpGet("[action]")]
        public async Task<IActionResult> GetAllRoles()
        {
            GetAllRolesRequest request = new();
            var response = await _mediator.Send(request);
            return Ok(response);
        }
        [HttpPost("[action]")]
        public async Task<IActionResult> UpdateRole(UpdateRoleRequest request)
        {
            var response = await _mediator.Send(request);
            return Ok(response);
        }
        [HttpGet("[action]/{id}")]
        public async Task<IActionResult> DeleteRoles(string id)
        {
            DeleteRoleRequest request = new() { Id = id };
            var response = await _mediator.Send(request);
            return Ok(response);
        }
    }
}

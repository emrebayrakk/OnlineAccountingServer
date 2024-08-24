using MediatR;
using Microsoft.AspNetCore.Mvc;
using OnlineAccountingServer.Application.Features.AppFeatures.AppUserFeatures.Commands.Register;
using OnlineAccountingServer.Application.Features.AppFeatures.AuthFeatures.Commands.Login;
using OnlineAccountingServer.Application.Features.AppFeatures.AuthFeatures.Queries.GetRolesByUserIdAndCompanyId;
using OnlineAccountingServer.Presentation.Abstraction;

namespace OnlineAccountingServer.Presentation.Controller
{
    public class AuthController : ApiController
    {
        public AuthController(IMediator mediator) : base(mediator)
        {
            
        }
        [HttpPost("[action]")]
        public async Task<IActionResult> Login(LoginCommand request)
        {
           var response = await _mediator.Send(request);
           return Ok(response);
        }
        [HttpPost("[action]")]
        public async Task<IActionResult> Register(RegisterCommand request)
        {
            var response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> GetRolesByUserIdAndCompanyId(GetRolesByUserIdAndCompanyIdQuery request)
        {
            var response = await _mediator.Send(request);
            return Ok(response);
        }
    }
}

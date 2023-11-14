using MediatR;
using Microsoft.AspNetCore.Mvc;
using OnlineAccountingServer.Application.Features.AppFeatures.AppUserFeatures.Login;
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
    }
}

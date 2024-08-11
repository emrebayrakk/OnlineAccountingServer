using MediatR;
using Microsoft.AspNetCore.Mvc;
using OnlineAccountingServer.Application.Features.AppFeatures.CompanyFeatures.Commands.CreateCompany;
using OnlineAccountingServer.Application.Features.AppFeatures.CompanyFeatures.Commands.MigrateCompanyDatabase;
using OnlineAccountingServer.Application.Features.AppFeatures.CompanyFeatures.Queries.GetAllCompany;
using OnlineAccountingServer.Presentation.Abstraction;

namespace OnlineAccountingServer.Presentation.Controller
{
    public class CompaniesController : ApiController
    {
        public CompaniesController(IMediator mediator) : base(mediator)
        {
        }
        [HttpPost("[action]")]
        public async Task<IActionResult> CreateCompany(CreateCompanyCommand createCompany, CancellationToken cancellationToken)
        {
           var response = await _mediator.Send(createCompany,cancellationToken);
            return Ok(response);

        }
        [HttpGet("[action]")]
        public async Task<IActionResult> MigrateCompanyDatabases()
        {
            MigrateCompanyDatabaseRequest migrateCompany = new MigrateCompanyDatabaseRequest();
            var response = await _mediator.Send(migrateCompany);
            return Ok(response);

        }
        [HttpGet("[action]")]
        public async Task<IActionResult> GetAllCompanies()
        {
            GetAllCompanyQuery request = new();
            var response = await _mediator.Send(request);
            return Ok(response);

        }

    }
}

using MediatR;
using OnlineAccountingServer.Application.Messaging;
using OnlineAccountingServer.Application.Services.CompanyService;
using OnlineAccountingServer.Domain.CompanyEntities;

namespace OnlineAccountingServer.Application.Features.CompanyFeatures.UCAFFeatures.Commands.CreateUCAF
{
    public class CreateUCAFCommandHandler : ICommandHandler<CreateUCAFCommand, CreateUCAFCommandResponse>
    {
        private readonly IUCAFService _ucafService;

        public CreateUCAFCommandHandler(IUCAFService ucafService)
        {
            _ucafService = ucafService;
        }

        public async Task<CreateUCAFCommandResponse> Handle(CreateUCAFCommand request, CancellationToken cancellationToken)
        {
            UniformChartOfAccount ucaf = await _ucafService.GetByCode(request.Code);
            if (ucaf != null) throw new Exception("Error");

            await _ucafService.CreateUcafAsync(request,cancellationToken);
            return new();
        }
    }
}

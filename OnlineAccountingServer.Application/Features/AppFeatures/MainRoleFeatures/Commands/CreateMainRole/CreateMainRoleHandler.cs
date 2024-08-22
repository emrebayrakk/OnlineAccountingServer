using OnlineAccountingServer.Application.Features.AppFeatures.MainRoleFeaatures.Commands.CreateRole;
using OnlineAccountingServer.Application.Messaging;
using OnlineAccountingServer.Application.Services.AppServices;
using OnlineAccountingServer.Domain.AppEntities;

namespace OnlineAccountingServer.Application.Features.AppFeatures.MainRoleFeaatures.Commands.CreateMainRole
{
    public sealed class CreateMainRoleHandler :
        ICommandHandler<CreateMainRoleCommand, CreateMainRoleResponse>
    {
        private readonly IMainRoleService _mainRoleService;

        public CreateMainRoleHandler(IMainRoleService mainRoleService)
        {
            _mainRoleService = mainRoleService;
        }

        public async Task<CreateMainRoleResponse> Handle(CreateMainRoleCommand request, CancellationToken cancellationToken)
        {
            MainRole checkMainRoleTitle = await _mainRoleService.
                GetByTitleAndCompanyId(request.Title, request.CompanyId,cancellationToken);

            if (checkMainRoleTitle != null)
            {
                throw new Exception("Error");
            }

            MainRole mainRole = new(
                Guid.NewGuid().ToString(),
                request.Title,
                request.CompanyId,
                request.CompanyId != null ? false : true);

            await _mainRoleService.CreateAsync(mainRole, cancellationToken);
            return new();
        }
    }
}

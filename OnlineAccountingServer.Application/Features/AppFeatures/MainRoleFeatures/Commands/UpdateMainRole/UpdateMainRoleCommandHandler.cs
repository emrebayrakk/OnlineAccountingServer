using OnlineAccountingServer.Application.Messaging;
using OnlineAccountingServer.Application.Services.AppService;
using OnlineAccountingServer.Domain.AppEntities;

namespace OnlineAccountingServer.Application.Features.AppFeatures.MainRoleFeatures.Commands.UpdateMainRole
{
    public sealed class UpdateMainRoleCommandHandler : ICommandHandler<UpdateMainRoleCommand, UpdateMainRoleCommandResponse>
    {
        private readonly IMainRoleService _mainRoleService;

        public UpdateMainRoleCommandHandler(IMainRoleService mainRoleService)
        {
            _mainRoleService = mainRoleService;
        }

        public async Task<UpdateMainRoleCommandResponse> Handle(UpdateMainRoleCommand request, CancellationToken cancellationToken)
        {
            MainRole mainRole = await _mainRoleService.GetByIdAsync(request.Id);
            if (mainRole == null) throw new Exception("Not Found!");

            if (mainRole.Title == request.Title) throw new Exception("Error");

            if (mainRole.Title != request.Title)
            {
                MainRole checkMainRoleTitle = await _mainRoleService.GetByTitleAndCompanyId(request.Title, mainRole.CompanyId, cancellationToken);
                if (checkMainRoleTitle != null) throw new Exception("Error");
            }

            mainRole.Title = request.Title;
            await _mainRoleService.UpdateAsync(mainRole);
            return new();
        }
    }
}

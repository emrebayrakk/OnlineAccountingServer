using OnlineAccountingServer.Application.Messaging;
using OnlineAccountingServer.Application.Services.AppServices;
using OnlineAccountingServer.Domain.AppEntities;
using OnlineAccountingServer.Domain.Role;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineAccountingServer.Application.Features.AppFeatures.MainRoleFeaatures.Commands.CreateStaticMainRoles
{
    public sealed class CreateStaticMainRolesCommandHandler : ICommandHandler<CreateStaticMainRolesCommand, CreateStaticMainRolesCommandResponse>
    {
        private readonly IMainRoleService _mainRoleService;

        public CreateStaticMainRolesCommandHandler(IMainRoleService mainRoleService)
        {
            _mainRoleService = mainRoleService;
        }

        public async Task<CreateStaticMainRolesCommandResponse> Handle(CreateStaticMainRolesCommand request, CancellationToken cancellationToken)
        {
            List<MainRole> mainRoles = RoleList.GetStaticMainRoles();
            List<MainRole> newMainRoles = new();
            foreach (var mainRole in mainRoles)
            {
                MainRole checkMainRole = await _mainRoleService.GetByTitleAndCompanyId(mainRole.Title
                    , mainRole.CompanyId, cancellationToken);
                if (checkMainRole == null)
                {
                    newMainRoles.Add(mainRole);
                }
            }
            await _mainRoleService.CreateRangeAsync(newMainRoles,cancellationToken);
            return new();
        }
    }
}

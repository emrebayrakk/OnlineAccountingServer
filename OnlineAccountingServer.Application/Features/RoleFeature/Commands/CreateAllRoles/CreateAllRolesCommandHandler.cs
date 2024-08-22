using OnlineAccountingServer.Application.Messaging;
using OnlineAccountingServer.Application.Services.AppServices;
using OnlineAccountingServer.Domain.AppEntities.Identity;
using OnlineAccountingServer.Domain.Role;

namespace OnlineAccountingServer.Application.Features.RoleFeature.Commands.CreateAllRoles
{
    public sealed class CreateAllRolesCommandHandler : ICommandHandler<CreateAllRolesCommand, CreateAllRolesCommandResponse>
    {
        private readonly IRoleService _roleService;

        public CreateAllRolesCommandHandler(IRoleService roleService)
        {
            _roleService = roleService;
        }

        public async Task<CreateAllRolesCommandResponse> Handle(CreateAllRolesCommand request, CancellationToken cancellationToken)
        {
            IList<AppRole> originalRoles = RoleList.GetStaticRoles();
            IList<AppRole> currentRoles = new List<AppRole>();

            foreach(var item in originalRoles)
            {
                AppRole checkRole = await _roleService.GetByCode(item.Code);
                if (checkRole == null) currentRoles.Add(item);
            }

            await _roleService.AddRangeAsync(currentRoles);
            throw new();
        }
    }
}

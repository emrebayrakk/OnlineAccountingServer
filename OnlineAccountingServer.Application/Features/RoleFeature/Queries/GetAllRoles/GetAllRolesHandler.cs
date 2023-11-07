using MediatR;
using OnlineAccountingServer.Application.Services.AppService;
using OnlineAccountingServer.Domain.AppEntities.Identity;

namespace OnlineAccountingServer.Application.Features.RoleFeature.Queries.GetAllRoles
{
    public sealed class GetAllRolesHandler : IRequestHandler<GetAllRolesRequest, GetAllRolesResponse>
    {
        private readonly IRoleService _roleService;

        public GetAllRolesHandler(IRoleService roleService)
        {
            _roleService = roleService;
        }

        public async Task<GetAllRolesResponse> Handle(GetAllRolesRequest request, CancellationToken cancellationToken)
        {
            IList<AppRole> roles = await _roleService.GetAllRoleAsync();
            return new GetAllRolesResponse { Roles = roles};
        }
    }
}

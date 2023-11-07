using MediatR;
using OnlineAccountingServer.Application.Services.AppService;

namespace OnlineAccountingServer.Application.Features.RoleFeature.Commands.DeleteRole
{
    public sealed class DeleteRoleHandler : IRequestHandler<DeleteRoleRequest, DeleteRoleResponse>
    {
        private readonly IRoleService _roleService;

        public DeleteRoleHandler(IRoleService roleService)
        {
            _roleService = roleService;
        }

        public async Task<DeleteRoleResponse> Handle(DeleteRoleRequest request, CancellationToken cancellationToken)
        {
            var role = await _roleService.GetById(request.Id);
            if (role == null) throw new Exception("Not Found");


            await _roleService.DeleteAsync(role);
            return new();
        }
    }
}

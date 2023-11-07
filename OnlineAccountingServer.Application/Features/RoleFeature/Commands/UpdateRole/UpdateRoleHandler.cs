using MediatR;
using Microsoft.EntityFrameworkCore;
using OnlineAccountingServer.Application.Services.AppService;

namespace OnlineAccountingServer.Application.Features.RoleFeature.Commands.UpdateRole
{
    public sealed class UpdateRoleHandler : IRequestHandler<UpdateRoleRequest, UpdateRoleResponse>
    {
        private readonly IRoleService _roleService;

        public UpdateRoleHandler(IRoleService roleService)
        {
            _roleService = roleService;
        }

        public async Task<UpdateRoleResponse> Handle(UpdateRoleRequest request, CancellationToken cancellationToken)
        {
            var role = await _roleService.GetById(request.Id);
            if (role == null) throw new Exception("Not Found");

            if (role.Code != request.Code)
            {
                var checkCode = await _roleService.GetByCode(request.Code);
                if (checkCode != null) throw new Exception("Error");

            }
            role.Code = request.Code;
            role.Name = request.Name;
            await _roleService.UpdateAsync(role);
            return new();
        }
    }
}

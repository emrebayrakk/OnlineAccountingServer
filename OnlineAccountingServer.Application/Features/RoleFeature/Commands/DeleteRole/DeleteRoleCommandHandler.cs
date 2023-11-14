using MediatR;
using OnlineAccountingServer.Application.Messaging;
using OnlineAccountingServer.Application.Services.AppService;

namespace OnlineAccountingServer.Application.Features.RoleFeature.Commands.DeleteRole
{
    public sealed class DeleteRoleCommandHandler : ICommandHandler<DeleteRoleCommand, DeleteRoleCommandResponse>
    {
        private readonly IRoleService _roleService;

        public DeleteRoleCommandHandler(IRoleService roleService)
        {
            _roleService = roleService;
        }

        public async Task<DeleteRoleCommandResponse> Handle(DeleteRoleCommand request, CancellationToken cancellationToken)
        {
            var role = await _roleService.GetById(request.Id);
            if (role == null) throw new Exception("Not Found");


            await _roleService.DeleteAsync(role);
            return new();
        }
    }
}

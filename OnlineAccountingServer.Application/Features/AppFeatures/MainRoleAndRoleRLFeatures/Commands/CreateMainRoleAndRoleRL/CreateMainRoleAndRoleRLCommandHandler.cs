using OnlineAccountingServer.Application.Messaging;
using OnlineAccountingServer.Application.Services.AppServices;
using OnlineAccountingServer.Domain.AppEntities;

namespace OnlineAccountingServer.Application.Features.AppFeatures.MainRoleAndRoleRLFeatures.Commands.CreateMainRoleAndRoleRL
{
    public sealed class CreateMainRoleAndRoleRLCommandHandler
        : ICommandHandler<CreateMainRoleAndRoleRLCommand, CreateMainRoleAndRoleRLCommandResponse>
    {
        private readonly IMainRoleAndRoleRelationshipService _roleRelationshipService;

        public CreateMainRoleAndRoleRLCommandHandler(IMainRoleAndRoleRelationshipService roleRelationshipService)
        {
            _roleRelationshipService = roleRelationshipService;
        }

        public async Task<CreateMainRoleAndRoleRLCommandResponse> Handle(CreateMainRoleAndRoleRLCommand request, CancellationToken cancellationToken)
        {

            var checkData = await _roleRelationshipService.AnyRoleIdAndMainRoleId(
                request.RoleId, request.MainRoleId, cancellationToken);
            if (checkData) throw new Exception("Error");

            MainRoleAndRoleRelationship mainRoleAndRoleRelationship = new(
                Guid.NewGuid().ToString(),
                request.RoleId,
                request.MainRoleId);
            await _roleRelationshipService.CreateAsync(mainRoleAndRoleRelationship,cancellationToken);

            return new();
        }
    }
}

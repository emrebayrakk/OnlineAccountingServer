using OnlineAccountingServer.Application.Messaging;
using OnlineAccountingServer.Application.Services.AppServices;
using OnlineAccountingServer.Domain.AppEntities;

namespace OnlineAccountingServer.Application.Features.AppFeatures.MainRoleAndUserRLFeatures.Commands.CreateMainRoleAndUserRL
{
    public sealed class CreateMainRoleAndUserRLCommandHandler
        : ICommandHandler<CreateMainRoleAndUserRLCommand, CreateMainRoleAndUserRLCommandResponse>
    {
        private readonly IMainRoleAndUserRelationshipService _mainRoleAndUserRelationshipService;

        public CreateMainRoleAndUserRLCommandHandler(IMainRoleAndUserRelationshipService mainRoleAndUserRelationshipService)
        {
            _mainRoleAndUserRelationshipService = mainRoleAndUserRelationshipService;
        }

        public async Task<CreateMainRoleAndUserRLCommandResponse> Handle(CreateMainRoleAndUserRLCommand request, CancellationToken cancellationToken)
        {
            var checkData = await _mainRoleAndUserRelationshipService.GetByUserIdCompanyIdAndMainRoleId
                (request.userId, request.companyId, request.mainRoleId, cancellationToken);
            if (checkData is not null) throw new Exception("Error");

            MainRoleAndUserRelationship mainRoleAndUserRelationship = new(
                Guid.NewGuid().ToString(),
                request.userId,
                request.mainRoleId,
                request.companyId);

            await _mainRoleAndUserRelationshipService.CreateAsync(mainRoleAndUserRelationship, cancellationToken);
            return new();
        }
    }
}

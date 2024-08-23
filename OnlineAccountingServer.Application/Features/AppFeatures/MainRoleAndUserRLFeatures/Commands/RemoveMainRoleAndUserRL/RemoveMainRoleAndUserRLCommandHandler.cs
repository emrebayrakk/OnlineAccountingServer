using OnlineAccountingServer.Application.Messaging;
using OnlineAccountingServer.Application.Services.AppServices;

namespace OnlineAccountingServer.Application.Features.AppFeatures.MainRoleAndUserRLFeatures.Commands.RemoveMainRoleAndUserRL
{
    public sealed class RemoveMainRoleAndUserRLCommandHandler
        : ICommandHandler<RemoveMainRoleAndUserRLCommand, RemoveMainRoleAndUserRLCommandResponse>
    {
        private readonly IMainRoleAndUserRelationshipService _mainRoleAndUserRelationshipService;

        public RemoveMainRoleAndUserRLCommandHandler(IMainRoleAndUserRelationshipService mainRoleAndUserRelationshipService)
        {
            _mainRoleAndUserRelationshipService = mainRoleAndUserRelationshipService;
        }

        public async Task<RemoveMainRoleAndUserRLCommandResponse> Handle(RemoveMainRoleAndUserRLCommand request, CancellationToken cancellationToken)
        {
            var checkData = _mainRoleAndUserRelationshipService.GetById(request.id);
            if (checkData is null) throw new Exception("Error");

            await _mainRoleAndUserRelationshipService.RemoveByIdAsync(request.id);
            return new();
        }
    }
}

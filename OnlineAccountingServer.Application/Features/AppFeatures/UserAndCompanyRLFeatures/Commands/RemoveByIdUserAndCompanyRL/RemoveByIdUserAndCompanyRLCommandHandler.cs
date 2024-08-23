using OnlineAccountingServer.Application.Messaging;
using OnlineAccountingServer.Application.Services.AppServices;

namespace OnlineAccountingServer.Application.Features.AppFeatures.UserAndCompanyRLFeatures.Commands.RemoveByIdUserAndCompanyRL
{
    public sealed class RemoveByIdUserAndCompanyRLCommandHandler
        : ICommandHandler<RemoveByIdUserAndCompanyRLCommand, RemoveByIdUserAndCompanyRLCommandResponse>
    {
        private readonly IUserAndCompanyRelationshipService _userAndCompanyRelationshipService;

        public RemoveByIdUserAndCompanyRLCommandHandler(IUserAndCompanyRelationshipService userAndCompanyRelationshipService)
        {
            _userAndCompanyRelationshipService = userAndCompanyRelationshipService;
        }

        public async Task<RemoveByIdUserAndCompanyRLCommandResponse> Handle(RemoveByIdUserAndCompanyRLCommand request, CancellationToken cancellationToken)
        {
            var checkUserAndCompanyEntity = _userAndCompanyRelationshipService
                .GetByIdAsync(request.Id);
            if (checkUserAndCompanyEntity == null) throw new Exception("Error");

            await _userAndCompanyRelationshipService.RemoveByIdAsync(request.Id);
            return new();
        }
    }
}

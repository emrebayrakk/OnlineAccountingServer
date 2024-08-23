using OnlineAccountingServer.Application.Messaging;
using OnlineAccountingServer.Application.Services.AppServices;
using OnlineAccountingServer.Domain.AppEntities;

namespace OnlineAccountingServer.Application.Features.AppFeatures.UserAndCompanyRLFeatures.Commands.CreateUserAndCompanyRL
{
    public sealed class CreateUserAndCompanyRLCommandHandler :
        ICommandHandler<CreateUserAndCompanyRLCommand, CreateUserAndCompanyRLCommandResponse>
    {
        private readonly IUserAndCompanyRelationshipService _userAndCompanyRelationshipService;

        public CreateUserAndCompanyRLCommandHandler(IUserAndCompanyRelationshipService userAndCompanyRelationshipService)
        {
            _userAndCompanyRelationshipService = userAndCompanyRelationshipService;
        }

        public async Task<CreateUserAndCompanyRLCommandResponse> Handle(CreateUserAndCompanyRLCommand request, CancellationToken cancellationToken)
        {
            var entity = await _userAndCompanyRelationshipService.GetByUserIdAndCompanyId(request.AppUserId, request.CompanyId);
            if (entity != null) throw new Exception("Error");

            UserAndCompanyRelationship userAndCompanyRelationship = new(
                Guid.NewGuid().ToString(),
                request.AppUserId,
                request.CompanyId);
            await _userAndCompanyRelationshipService.CreateAsync(userAndCompanyRelationship,cancellationToken);
            return new();
        }
    }
}

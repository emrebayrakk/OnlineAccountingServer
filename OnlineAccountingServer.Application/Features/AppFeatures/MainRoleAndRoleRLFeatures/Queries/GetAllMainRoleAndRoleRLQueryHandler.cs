using Microsoft.EntityFrameworkCore;
using OnlineAccountingServer.Application.Messaging;
using OnlineAccountingServer.Application.Services.AppServices;

namespace OnlineAccountingServer.Application.Features.AppFeatures.MainRoleAndRoleRLFeatures.Queries
{
    public sealed class GetAllMainRoleAndRoleRLQueryHandler :
        IQueryHandler<GetAllMainRoleAndRoleRLQuery, GetAllMainRoleAndRoleRLQueryResponse>
    {
        private readonly IMainRoleAndRoleRelationshipService _roleRelationshipService;

        public GetAllMainRoleAndRoleRLQueryHandler(IMainRoleAndRoleRelationshipService roleRelationshipService)
        {
            _roleRelationshipService = roleRelationshipService;
        }

        public async Task<GetAllMainRoleAndRoleRLQueryResponse> Handle(GetAllMainRoleAndRoleRLQuery request, CancellationToken cancellationToken)
        {
            var item = await _roleRelationshipService.GetAll().Include("AppRole").Include("MainRole").ToListAsync();
            return new(item);
        }
    }
}

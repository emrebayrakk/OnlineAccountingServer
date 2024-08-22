using OnlineAccountingServer.Domain.AppEntities;

namespace OnlineAccountingServer.Application.Features.AppFeatures.MainRoleAndRoleRLFeatures.Queries
{
    public sealed record GetAllMainRoleAndRoleRLQueryResponse(
        IList<MainRoleAndRoleRelationship> Roles);
}

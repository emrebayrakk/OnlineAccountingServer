using OnlineAccountingServer.Domain.AppEntities;

namespace OnlineAccountingServer.Application.Features.AppFeatures.MainRoleFeaatures.Queries.GetAllMainRole
{
    public sealed record GetAllMainRoleQueryResponse(
        IList<MainRole> MainRoles);
}

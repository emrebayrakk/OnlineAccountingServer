using OnlineAccountingServer.Application.Messaging;

namespace OnlineAccountingServer.Application.Features.AppFeatures.AuthFeatures.Queries.GetRolesByUserIdAndCompanyId
{
    public sealed record GetRolesByUserIdAndCompanyIdQuery(
        string UserId,
        string CompanyId) : IQuery<GetRolesByUserIdAndCompanyIdQueryResponse>;
}

using OnlineAccountingServer.Domain.AppEntities;

namespace OnlineAccountingServer.Application.Features.AppFeatures.CompanyFeatures.Queries.GetAllCompany
{
    public sealed record GetAllCompanyQueryResponse(List<Company> Companies);
}

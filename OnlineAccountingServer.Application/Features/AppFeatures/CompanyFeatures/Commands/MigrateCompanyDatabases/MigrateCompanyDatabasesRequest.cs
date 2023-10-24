using MediatR;

namespace OnlineAccountingServer.Application.Features.AppFeatures.CompanyFeatures.Commands.MigrateCompanyDatabase
{
    public sealed class MigrateCompanyDatabaseRequest : IRequest<MigrateCompanyDatabasesResponse>
    {
    }
}

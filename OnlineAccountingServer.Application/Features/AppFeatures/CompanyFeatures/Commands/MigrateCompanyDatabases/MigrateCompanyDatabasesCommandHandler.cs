using OnlineAccountingServer.Application.Messaging;
using OnlineAccountingServer.Application.Services.AppService;

namespace OnlineAccountingServer.Application.Features.AppFeatures.CompanyFeatures.Commands.MigrateCompanyDatabase
{
    public sealed class MigrateCompanyDatabasesCommandHandler : ICommandHandler<MigrateCompanyDatabaseRequest, MigrateCompanyDatabasesCommandResponse>
    {
        private readonly ICompanyService _companyService;

        public MigrateCompanyDatabasesCommandHandler(ICompanyService companyService)
        {
            _companyService = companyService;
        }

        public async Task<MigrateCompanyDatabasesCommandResponse> Handle(MigrateCompanyDatabaseRequest request, CancellationToken cancellationToken)
        {
            await _companyService.MigrateCompanyDatabases();
            return new();
        }
    }
}

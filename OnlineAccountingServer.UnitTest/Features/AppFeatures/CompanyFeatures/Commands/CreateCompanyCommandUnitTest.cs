using Moq;
using OnlineAccountingServer.Application.Features.AppFeatures.CompanyFeatures.Commands.CreateCompany;
using OnlineAccountingServer.Application.Services.AppService;
using OnlineAccountingServer.Domain.AppEntities;
using Shouldly;

namespace OnlineAccountingServer.UnitTest.Features.AppFeatures.CompanyFeatures.Commands
{
    public sealed class CreateCompanyCommandUnitTest
    {
        private readonly Mock<ICompanyService> _companyService;

        public CreateCompanyCommandUnitTest()
        {
            _companyService = new();
        }

        [Fact]
        public async Task CompanyShouldBeNull()
        {
            Company company = (await _companyService.Object.GetCompanyByName("Test Ltd"))!;
            company.ShouldBeNull();
        }
        [Fact]
        public async Task CreateCompanyCommandResponseShouldNotBeNull()
        {
            var command = new CreateCompanyCommand(
                Name:"Test Ltd",
                ServerName: "LocalHost",
                DatabaseName: "TestDb",
                UserId: "",
                Password:"");
            var handler = new CreateCompanyCommandHandler(_companyService.Object);
            CreateCompanyCommandResponse response = await handler.Handle(command,default);
            response.ShouldNotBeNull();
            response.Message.ShouldNotBeEmpty();
        }
    }
}

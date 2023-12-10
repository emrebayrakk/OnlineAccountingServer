using Moq;
using OnlineAccountingServer.Application.Features.CompanyFeatures.UCAFFeatures.Commands.CreateUCAF;
using OnlineAccountingServer.Application.Services.CompanyService;
using OnlineAccountingServer.Domain.CompanyEntities;
using Shouldly;

namespace OnlineAccountingServer.UnitTest.Features.CompanyFeatures.Commands
{
    public sealed class CreateUCAFCommandUnitTest
    {
        private readonly Mock<IUCAFService> _ucafService;
        public CreateUCAFCommandUnitTest()
        {
            _ucafService = new();
        }
        [Fact]
        public async Task UCAFShouldBeNull()
        {
            UniformChartOfAccount ucaf = await _ucafService.Object.GetByCode("123");
            ucaf.ShouldBeNull();
        }
        [Fact]
        public async Task CreateUCAFCommandResponseShouldNotBeNull()
        {
            var command = new CreateUCAFCommand(
                Code: "12312",
                Name: "Test",
                Type: 'T',
                CompanyId: "wdıjqldqjşdqkşq");

            var handler = new CreateUCAFCommandHandler(_ucafService.Object);
            var response = await handler.Handle(command, default);
            response.ShouldNotBeNull();
            response.Message.ShouldNotBeEmpty();

        }
    }
}

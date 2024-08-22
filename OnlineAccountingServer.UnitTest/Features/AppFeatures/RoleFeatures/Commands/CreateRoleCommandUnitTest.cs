using Moq;
using OnlineAccountingServer.Application.Features.RoleFeature.Commands.CreateRole;
using OnlineAccountingServer.Application.Services.AppServices;
using OnlineAccountingServer.Domain.AppEntities.Identity;
using Shouldly;

namespace OnlineAccountingServer.UnitTest.Features.AppFeatures.RoleFeatures.Commands
{
    public sealed class CreateRoleCommandUnitTest
    {
        private readonly Mock<IRoleService> _roleService;
        public CreateRoleCommandUnitTest()
        {
            _roleService = new();
        }
        [Fact]
        public async Task AppRoleShouldBeNull()
        {
            AppRole appRole = await _roleService.Object.GetByCode("UCAF.Create");
            appRole.ShouldBeNull();
        }
        [Fact]
        public async Task CreateRoleCommandResponseShouldBeNull()
        {
            var command = new CreateRoleCommand(
                Code: "UCAF.Create",
                Name: "Added");
            var handler = new CreateRoleCommandHandler(_roleService.Object);

            CreateRoleCommandResponse response = await handler.Handle(command, default);
            response.ShouldNotBeNull();
            response.Message.ShouldNotBeEmpty();
        }
    }
}

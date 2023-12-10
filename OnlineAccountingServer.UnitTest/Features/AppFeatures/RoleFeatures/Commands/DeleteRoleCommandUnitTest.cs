using Moq;
using OnlineAccountingServer.Application.Features.RoleFeature.Commands.DeleteRole;
using OnlineAccountingServer.Application.Services.AppService;
using OnlineAccountingServer.Domain.AppEntities.Identity;
using Shouldly;

namespace OnlineAccountingServer.UnitTest.Features.AppFeatures.RoleFeatures.Commands
{
    public sealed class DeleteRoleCommandUnitTest
    {
        private readonly Mock<IRoleService> _roleService;
        public DeleteRoleCommandUnitTest()
        {
            _roleService = new();
        }
        [Fact]
        public void AppRoleShouldNotBeNull()
        {
            _ = _roleService.Setup(
                x => x.GetById(It.IsAny<string>())
                ).ReturnsAsync(new AppRole());

        }
        [Fact]
        public async Task DeleteRoleCommandResponseShouldNotBeNull()
        {
            var command = new DeleteRoleCommand(
                Id: "2e9b58d0-d3bc-4210-b5be-975b757ef452");
            var handler = new DeleteRoleCommandHandler(_roleService.Object);

            _roleService.Setup(x => x.GetById(It.IsAny<string>())).ReturnsAsync(new AppRole());

            DeleteRoleCommandResponse response = await handler.Handle(command, default);
            response.ShouldNotBeNull();
            response.Message.ShouldNotBeEmpty();
        }
    }
}

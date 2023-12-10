using Moq;
using OnlineAccountingServer.Application.Features.RoleFeature.Commands.UpdateRole;
using OnlineAccountingServer.Application.Services.AppService;
using OnlineAccountingServer.Domain.AppEntities.Identity;
using Shouldly;

namespace OnlineAccountingServer.UnitTest.Features.AppFeatures.RoleFeatures.Commands
{
    public sealed class UpdateRoleCommandUnitTest
    {
        private readonly Mock<IRoleService> _roleService;
        public UpdateRoleCommandUnitTest()
        {
            _roleService = new();
        }
        [Fact]
        public void AppRoleShouldNotBeNull()
        {
            _ = _roleService.Setup(x => x.GetById(It.IsAny<string>())).ReturnsAsync(new AppRole());

        }
        [Fact]
        public async Task AppRoleCodeShouldBeUniqe()
        {
            AppRole checkRoleCode = await _roleService.Object.GetByCode("UCAF.Create");
            checkRoleCode.ShouldBeNull();
        }
        [Fact]
        public async Task UpdateRoleCommandResponseShouldNotBeNull()
        {
            var command = new UpdateRoleCommand(
                Id: "2e9b58d0-d3bc-4210-b5be-975b757ef452",
                Code: "UCAF.Create",
                Name: "Updated");
            var handler = new UpdateRoleCommandHandler(_roleService.Object);

            _roleService.Setup(x => x.GetById(It.IsAny<string>())).ReturnsAsync(new AppRole());

            UpdateRoleCommandResponse response = await handler.Handle(command, default);
            response.ShouldNotBeNull();
            response.Message.ShouldNotBeEmpty();
        }
    }
}

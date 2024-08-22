using Moq;
using OnlineAccountingServer.Application.Features.RoleFeature.Queries.GetAllRoles;
using OnlineAccountingServer.Application.Services.AppServices;
using OnlineAccountingServer.Domain.AppEntities.Identity;
using Shouldly;

namespace OnlineAccountingServer.UnitTest.Features.AppFeatures.RoleFeatures.Queries
{
    public sealed class GetAllRolesQueryUnitTest
    {
        private readonly Mock<IRoleService> _roleService;
        public GetAllRolesQueryUnitTest()
        {
            _roleService = new();
        }
        [Fact]
        public async Task GetAllRolesQueryResponseShouldNotBeNull()
        {
            var command = new GetAllRolesQuery();
            var handler = new GetAllRolesQueryHandler(_roleService.Object);

            _roleService.Setup(
                x => x.GetAllRoleAsync()).ReturnsAsync(new List<AppRole>());

            var response = await handler.Handle(command,default);
            response.ShouldNotBeNull();
            response.Roles.ShouldNotBeNull();
        }
    }
}

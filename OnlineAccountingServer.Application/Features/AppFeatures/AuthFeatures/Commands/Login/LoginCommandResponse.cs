using OnlineAccountingServer.Domain.Dtos;

namespace OnlineAccountingServer.Application.Features.AppFeatures.AuthFeatures.Commands.Login
{
    public sealed record LoginCommandResponse(
         string Email,
         string UserId,
         string NameLastName,
         TokenRefreshTokenDto Token,
         IList<CompanyDto> Companies,
         CompanyDto Company
         );
}

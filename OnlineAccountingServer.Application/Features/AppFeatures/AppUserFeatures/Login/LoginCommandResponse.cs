using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineAccountingServer.Application.Features.AppFeatures.AppUserFeatures.Login
{
    public sealed record LoginCommandResponse(string Token,
         string Email,
         string UserId,
         string NameLastName
         );
}

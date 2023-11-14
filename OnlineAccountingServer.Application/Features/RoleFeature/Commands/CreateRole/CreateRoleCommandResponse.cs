using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineAccountingServer.Application.Features.RoleFeature.Commands.CreateRole
{
    public sealed record CreateRoleCommandResponse(string Message = "Succesfull");
}

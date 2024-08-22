using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineAccountingServer.Application.Features.AppFeatures.MainRoleAndRoleRLFeatures.Commands.RemoveByIdMainRoleAndRoleRL
{
    public sealed record RemoveByIdMainRoleAndRoleRLCommandResponse(
        string Message = "Success");
}

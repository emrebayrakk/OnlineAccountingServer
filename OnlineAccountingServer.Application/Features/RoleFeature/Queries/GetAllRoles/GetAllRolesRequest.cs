using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineAccountingServer.Application.Features.RoleFeature.Queries.GetAllRoles
{
    public sealed class GetAllRolesRequest : IRequest<GetAllRolesResponse>
    {
    }
}

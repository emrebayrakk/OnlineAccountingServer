﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineAccountingServer.Application.Features.RoleFeature.Commands.DeleteRole
{
    public sealed record DeleteRoleCommandResponse(string Message = "Succesfull");
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineAccountingServer.Application.Features.AppFeatures.MainRoleFeatures.Commands.RemoveByIdMainRole
{
    public sealed record RemoveByIdMainRoleCommandResponse(
      string Message = "Successfull");
}

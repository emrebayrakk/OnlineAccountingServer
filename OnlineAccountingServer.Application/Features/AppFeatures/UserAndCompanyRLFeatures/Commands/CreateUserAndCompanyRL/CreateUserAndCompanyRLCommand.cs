﻿using OnlineAccountingServer.Application.Messaging;

namespace OnlineAccountingServer.Application.Features.AppFeatures.UserAndCompanyRLFeatures.Commands.CreateUserAndCompanyRL
{
    public sealed record CreateUserAndCompanyRLCommand(
        string AppUserId,
        string CompanyId) :
        ICommand<CreateUserAndCompanyRLCommandResponse>;
}

﻿using FluentValidation;

namespace OnlineAccountingServer.Application.Features.AppFeatures.MainRoleFeatures.Commands.RemoveByIdMainRole
{
    public sealed class RemoveByIdMainRoleCommandValidator : AbstractValidator<RemoveByIdMainRoleCommand>
    {
        public RemoveByIdMainRoleCommandValidator()
        {
            RuleFor(p => p.Id).NotEmpty().WithMessage("Id alanı boş olamaz!");
            RuleFor(p => p.Id).NotNull().WithMessage("Id alanı boş olamaz!");
        }
    }
}

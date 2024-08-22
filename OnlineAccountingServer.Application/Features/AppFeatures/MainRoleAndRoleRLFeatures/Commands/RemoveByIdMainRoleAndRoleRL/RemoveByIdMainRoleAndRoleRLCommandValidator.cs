using FluentValidation;

namespace OnlineAccountingServer.Application.Features.AppFeatures.MainRoleAndRoleRLFeatures.Commands.RemoveByIdMainRoleAndRoleRL
{
    public sealed class RemoveByIdMainRoleAndRoleRLCommandValidator
    : AbstractValidator<RemoveByIdMainRoleAndRoleRLCommand>
    {
        public RemoveByIdMainRoleAndRoleRLCommandValidator()
        {
            RuleFor(p => p.Id).NotEmpty().WithMessage("Id Should Be Selected!");
            RuleFor(p => p.Id).NotNull().WithMessage("Id Should Be Selected!");
        }
    }
}

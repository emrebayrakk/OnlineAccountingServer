using FluentValidation;

namespace OnlineAccountingServer.Application.Features.AppFeatures.MainRoleAndUserRLFeatures.Commands.RemoveMainRoleAndUserRL
{
    public sealed class RemoveMainRoleAndUserRLCommandValidator
        : AbstractValidator<RemoveMainRoleAndUserRLCommand>
    {
        public RemoveMainRoleAndUserRLCommandValidator()
        {
            RuleFor(p => p.id).NotEmpty().WithMessage("Should Be Selected!");
            RuleFor(p => p.id).NotNull().WithMessage("Should Be Selected!");
        }
    }
}

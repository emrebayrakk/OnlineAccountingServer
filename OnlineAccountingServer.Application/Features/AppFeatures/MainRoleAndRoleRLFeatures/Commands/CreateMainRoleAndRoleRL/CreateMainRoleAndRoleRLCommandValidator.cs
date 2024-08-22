using FluentValidation;

namespace OnlineAccountingServer.Application.Features.AppFeatures.MainRoleAndRoleRLFeatures.Commands.CreateMainRoleAndRoleRL
{
    public sealed class CreateMainRoleAndRoleRLCommandValidator
        : AbstractValidator<CreateMainRoleAndRoleRLCommand>
    {
        public CreateMainRoleAndRoleRLCommandValidator()
        {
            RuleFor(p => p.RoleId).NotEmpty().WithMessage("Role Should Be Selected!");
            RuleFor(p => p.RoleId).NotNull().WithMessage("Role Should Be Selected!");

            RuleFor(p => p.RoleId).NotEmpty().WithMessage("Main Role Should Be Selected!");
            RuleFor(p => p.RoleId).NotNull().WithMessage("Main Role Should Be Selected!");
        }
    }
}

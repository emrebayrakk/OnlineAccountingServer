using FluentValidation;

namespace OnlineAccountingServer.Application.Features.AppFeatures.MainRoleAndUserRLFeatures.Commands.CreateMainRoleAndUserRL
{
    public sealed class CreateMainRoleAndUserRLCommandValidator :
        AbstractValidator<CreateMainRoleAndUserRLCommand>
    {
        public CreateMainRoleAndUserRLCommandValidator()
        {
            RuleFor(p => p.userId).NotEmpty().WithMessage("User Should Be Selected!");
            RuleFor(p => p.userId).NotNull().WithMessage("User Should Be Selected!");

            RuleFor(p => p.companyId).NotEmpty().WithMessage("Company Should Be Selected!");
            RuleFor(p => p.companyId).NotNull().WithMessage("Company Role Should Be Selected!");

            RuleFor(p => p.mainRoleId).NotEmpty().WithMessage("Main Role Should Be Selected!");
            RuleFor(p => p.mainRoleId).NotNull().WithMessage("Main Role Role Should Be Selected!");
        }
    }
}

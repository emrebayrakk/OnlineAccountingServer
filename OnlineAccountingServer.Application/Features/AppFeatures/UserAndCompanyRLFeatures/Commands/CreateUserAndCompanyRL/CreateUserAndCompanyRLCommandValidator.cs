using FluentValidation;

namespace OnlineAccountingServer.Application.Features.AppFeatures.UserAndCompanyRLFeatures.Commands.CreateUserAndCompanyRL
{
    public sealed class CreateUserAndCompanyRLCommandValidator :
        AbstractValidator<CreateUserAndCompanyRLCommand>
    {
        public CreateUserAndCompanyRLCommandValidator()
        {
            RuleFor(p => p.AppUserId).NotEmpty().WithMessage("User Should Be Selected!");
            RuleFor(p => p.AppUserId).NotNull().WithMessage("User Should Be Selected!");

            RuleFor(p => p.CompanyId).NotEmpty().WithMessage("Company Should Be Selected!");
            RuleFor(p => p.CompanyId).NotNull().WithMessage("Company Role Should Be Selected!");
        }
    }
}

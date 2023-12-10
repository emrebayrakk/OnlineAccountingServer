using FluentValidation;

namespace OnlineAccountingServer.Application.Features.AppFeatures.AppUserFeatures.Commands.Register
{
    public sealed class RegisterCommandValidator : AbstractValidator<RegisterCommand>
    {
        public RegisterCommandValidator()
        {
            RuleFor(a => a.email).NotEmpty().WithMessage("Email cannot be empty");
            RuleFor(a => a.email).NotNull().WithMessage("Email cannot be empty");

            RuleFor(a => a.password).NotEmpty().WithMessage("Password cannot be empty");
            RuleFor(a => a.password).NotNull().WithMessage("Password cannot be empty");

            RuleFor(p => p.password).MinimumLength(6).WithMessage("Password must be at least 6 characters");
            RuleFor(p => p.password).Matches("[A-Z]").WithMessage("Your password must contain at least 1 uppercase letter.");
            RuleFor(p => p.password).Matches("[a-z]").WithMessage("Your password must contain at least 1 lowercase letter.");
            RuleFor(p => p.password).Matches("[0-9]").WithMessage("Your password must contain at least 1 number");
            RuleFor(p => p.password).Matches("[^a-zA-Z0-9]").WithMessage("Your password must contain at least 1 special character");
        }
    }
}

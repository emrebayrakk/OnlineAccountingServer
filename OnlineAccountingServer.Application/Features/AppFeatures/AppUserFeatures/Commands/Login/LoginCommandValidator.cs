using FluentValidation;

namespace OnlineAccountingServer.Application.Features.AppFeatures.AppUserFeatures.Commands.Login
{
    public sealed class LoginCommandValidator : AbstractValidator<LoginCommand>
    {
        public LoginCommandValidator()
        {
            RuleFor(a => a.EmailOrUserName).NotEmpty().WithMessage("Email or user name cannot be empty");
            RuleFor(a => a.EmailOrUserName).NotNull().WithMessage("Email or user name cannot be empty");

            RuleFor(a => a.Password).NotEmpty().WithMessage("Password cannot be empty");
            RuleFor(a => a.Password).NotNull().WithMessage("Password cannot be empty");
        }
    }
}

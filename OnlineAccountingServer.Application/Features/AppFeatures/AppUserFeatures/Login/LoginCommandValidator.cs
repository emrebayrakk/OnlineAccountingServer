using FluentValidation;

namespace OnlineAccountingServer.Application.Features.AppFeatures.AppUserFeatures.Login
{
    public sealed class LoginCommandValidator : AbstractValidator<LoginCommand>
    {
        public LoginCommandValidator()
        {
            RuleFor(a => a.EmailOrUserName).NotEmpty().WithMessage("mail or user name cannot be empty");
            RuleFor(a => a.EmailOrUserName).NotNull().WithMessage("mail or user name cannot be empty");

            RuleFor(a => a.Password).NotEmpty().WithMessage("password cannot be empty");
            RuleFor(a => a.Password).NotNull().WithMessage("password cannot be empty");
        }
    }
}

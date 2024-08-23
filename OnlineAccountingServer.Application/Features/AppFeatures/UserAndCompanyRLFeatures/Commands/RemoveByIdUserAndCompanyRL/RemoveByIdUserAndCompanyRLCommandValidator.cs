using FluentValidation;

namespace OnlineAccountingServer.Application.Features.AppFeatures.UserAndCompanyRLFeatures.Commands.RemoveByIdUserAndCompanyRL
{
    public sealed class RemoveByIdUserAndCompanyRLCommandValidator
        : AbstractValidator<RemoveByIdUserAndCompanyRLCommand>
    {
        public RemoveByIdUserAndCompanyRLCommandValidator()
        {
            RuleFor(p => p.Id).NotEmpty().WithMessage("Should Be Selected!");
            RuleFor(p => p.Id).NotNull().WithMessage("Should Be Selected!");
        }
    }
}

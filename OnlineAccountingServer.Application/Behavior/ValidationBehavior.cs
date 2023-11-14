using FluentValidation;
using FluentValidation.Results;
using MediatR;
using OnlineAccountingServer.Application.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineAccountingServer.Application.Behavior
{
    public sealed class ValidationBehavior<TRequest, TResponse> :
        IPipelineBehavior<TRequest, TResponse>
        where TRequest :class, ICommand<TResponse>
    {
        private readonly IEnumerable<IValidator<TRequest>> _valiators;
        public ValidationBehavior(IEnumerable<IValidator<TRequest>> valiators)
        {
                _valiators = valiators;
        }
        public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
        {
            if (!_valiators.Any())
            {
                return await next();
            }
            var context = new ValidationContext<TRequest>(request);

            var errorDictionary = _valiators.
                Select(a => a.Validate(context))
                .SelectMany(a => a.Errors)
                .Where(a => a != null)
                .GroupBy(a => a.PropertyName, a => a.ErrorMessage,
                (propertyName, errorMessage) => new
                {
                    Key = propertyName,
                    Values = errorMessage.Distinct().ToList()
                })
                .ToDictionary(a => a.Key, a => a.Values[0]);

            if (errorDictionary.Any())
            {
                var errors = errorDictionary.Select(a => new ValidationFailure
                {
                    PropertyName = a.Value,
                    ErrorCode = a.Key,
                });
                throw new ValidationException(errors);
            }
            return await next();

        }
    }
}

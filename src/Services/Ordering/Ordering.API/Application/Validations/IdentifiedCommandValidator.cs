using FluentValidation;
using EY.Digital.Services.Ordering.API.Application.Commands;

namespace EY.Digital.Services.Ordering.API.Application.Validations
{
    public class IdentifiedCommandValidator : AbstractValidator<IdentifiedCommand<CreateOrderCommand,bool>>
    {
        public IdentifiedCommandValidator()
        {
            RuleFor(command => command.Id).NotEmpty();    
        }
    }
}

using FluentValidation;
using EY.Digital.Services.Forecasting.API.Application.Commands;

namespace EY.Digital.Services.Forecasting.API.Application.Validations
{
    public class IdentifiedCommandValidator : AbstractValidator<IdentifiedCommand<CreateOrderForecastCommand,bool>>
    {
        public IdentifiedCommandValidator()
        {
            RuleFor(command => command.Id).NotEmpty();    
        }
    }
}

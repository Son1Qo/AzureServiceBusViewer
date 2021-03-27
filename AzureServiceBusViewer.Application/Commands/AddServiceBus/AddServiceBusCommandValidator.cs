using FluentValidation;

namespace AzureServiceBusViewer.Application.Commands.AddServiceBus
{
    public class AddServiceBusCommandValidator : AbstractValidator<AddServiceBusCommand>
    {
        public AddServiceBusCommandValidator()
        {
            RuleFor(property => property.ConnectionString)
                .NotEmpty();
        }
        
    }
}
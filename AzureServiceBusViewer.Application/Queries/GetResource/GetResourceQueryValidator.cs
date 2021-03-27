using FluentValidation;

namespace AzureServiceBusViewer.Application.Queries.GetResource
{
    public class GetResourceQueryValidator : AbstractValidator<GetResourceQuery>
    {
        public GetResourceQueryValidator()
        {
            RuleFor(r => r.ConnectionString)
                .NotEmpty();

            RuleFor(r => r.ResourceName)
                .NotEmpty();
        }
        
    }
}
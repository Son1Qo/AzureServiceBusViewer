using FluentValidation;

namespace AzureServiceBusViewer.Application.Queries.GetResources
{
    public sealed class GetResourcesQueryValidator : AbstractValidator<GetResourcesQuery>
    {
        public GetResourcesQueryValidator()
        {
            RuleFor(r => r.ConnectionString)
                .NotEmpty();
        }
    }
}
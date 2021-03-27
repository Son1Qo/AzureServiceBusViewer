using AzureServiceBusViewer.Application.Contracts;
using MediatR;

namespace AzureServiceBusViewer.Application.Queries.GetResource
{
    public sealed class GetResourceQuery : IRequest<Resource>
    {
        public string ConnectionString { get; set; }
        public string ResourceName { get; set; }
    }
}
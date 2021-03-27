using System.Collections.ObjectModel;
using AzureServiceBusViewer.Application.Contracts;
using MediatR;

namespace AzureServiceBusViewer.Application.Queries.GetResources
{
    public sealed class GetResourcesQuery : IRequest<ReadOnlyCollection<Resource>>
    {
        public string ConnectionString { get; set; }
    }
}
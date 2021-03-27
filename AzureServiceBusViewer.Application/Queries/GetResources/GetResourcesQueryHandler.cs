using System.Collections.ObjectModel;
using System.Threading;
using System.Threading.Tasks;
using AzureServiceBusViewer.Application.Contracts;
using AzureServiceBusViewer.Application.Interfaces;
using MediatR;

namespace AzureServiceBusViewer.Application.Queries.GetResources
{
    public sealed class GetResourcesQueryHandler : IRequestHandler<GetResourcesQuery, ReadOnlyCollection<Resource>>
    {
        private readonly IServiceBusManager _serviceBusManager;

        public GetResourcesQueryHandler(IServiceBusManager serviceBusManager)
        {
            _serviceBusManager = serviceBusManager;
        }
        
        public async Task<ReadOnlyCollection<Resource>> Handle(GetResourcesQuery request, 
            CancellationToken cancellationToken) => 
            await _serviceBusManager.GetResourcesAsync(request.ConnectionString);
    }
}
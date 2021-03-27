using System.Threading;
using System.Threading.Tasks;
using AzureServiceBusViewer.Application.Contracts;
using AzureServiceBusViewer.Application.Interfaces;
using MediatR;

namespace AzureServiceBusViewer.Application.Queries.GetResource
{
    public class GetResourceQueryHandler : IRequestHandler<GetResourceQuery, Resource>
    {
        private readonly IServiceBusManager _serviceBusManager;

        public GetResourceQueryHandler(IServiceBusManager serviceBusManager)
        {
            _serviceBusManager = serviceBusManager;
        }

        public async Task<Resource> Handle(GetResourceQuery request, CancellationToken cancellationToken) =>
            await _serviceBusManager.GetResourceAsync(request.ConnectionString, request.ResourceName);
    }
}
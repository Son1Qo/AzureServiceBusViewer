using System.Threading;
using System.Threading.Tasks;
using AzureServiceBusViewer.Application.Interfaces;
using MediatR;

namespace AzureServiceBusViewer.Application.Commands.AddServiceBus
{
    public class AddServiceBusHandler : AsyncRequestHandler<AddServiceBusCommand>
    {
        private readonly IServiceBusManager _serviceBusManager;

        public AddServiceBusHandler(IServiceBusManager serviceBusManager)
        {
            _serviceBusManager = serviceBusManager;
        }
        
        protected override Task Handle(AddServiceBusCommand request, CancellationToken cancellationToken)
        {
            
            
            return Task.CompletedTask;
        }
    }
}
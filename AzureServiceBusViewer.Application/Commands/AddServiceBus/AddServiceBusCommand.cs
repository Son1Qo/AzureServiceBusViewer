using MediatR;

namespace AzureServiceBusViewer.Application.Commands.AddServiceBus
{
    public sealed class AddServiceBusCommand : IRequest
    {
        public string ConnectionString { get; set; }
    }
}
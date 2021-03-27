using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using AzureServiceBusViewer.Application.Contracts;
using AzureServiceBusViewer.Application.Interfaces;
using Microsoft.Azure.ServiceBus.Management;

namespace AzureServiceBusViewer.Infrastructure.Services
{
    public class ServiceBusManager : IServiceBusManager
    {
        public async Task<ReadOnlyCollection<Resource>> GetResourcesAsync(string connectionString)
        {
            var client = new ManagementClient(connectionString);
            var getQueuesTask = client.GetQueuesRuntimeInfoAsync();
            var getTopicsTask = client.GetTopicsRuntimeInfoAsync();

            await Task.WhenAll(getQueuesTask, getTopicsTask);

            var resources = getQueuesTask.Result.Select(r => new Resource
                {
                    Name = r.Path,
                    Type = ResourceType.Queue,
                    MessageCount = r.MessageCountDetails.ActiveMessageCount,
                    DeadLetterCount = r.MessageCountDetails.DeadLetterMessageCount
                })
                .ToList();
            
            resources.AddRange(getTopicsTask.Result.Select(t => new Resource
            {
                Name = t.Path,
                Type = ResourceType.Topic
            }));

            return resources.AsReadOnly();
        }

        public async Task<Resource> GetResourceAsync(string connectionString, string resourceName)
        {
            var client = new ManagementClient(connectionString);
            var result = await client.GetQueueRuntimeInfoAsync(resourceName);

            return new Resource
            {
                Name = result.Path,
                Type = ResourceType.Queue,
                MessageCount = result.MessageCountDetails.ActiveMessageCount,
                DeadLetterCount = result.MessageCountDetails.DeadLetterMessageCount
            };
        }
    }
}
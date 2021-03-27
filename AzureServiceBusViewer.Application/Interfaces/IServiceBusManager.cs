using System.Collections.ObjectModel;
using System.Threading.Tasks;
using AzureServiceBusViewer.Application.Contracts;

namespace AzureServiceBusViewer.Application.Interfaces
{
    public interface IServiceBusManager
    {
        Task<ReadOnlyCollection<Resource>> GetResourcesAsync(string connectionString);
        Task<Resource> GetResourceAsync(string connectionString, string resourceName);
    }
}
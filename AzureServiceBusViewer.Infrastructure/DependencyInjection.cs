using AzureServiceBusViewer.Application.Interfaces;
using AzureServiceBusViewer.Infrastructure.Services;
using Microsoft.Extensions.DependencyInjection;

namespace AzureServiceBusViewer.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddScoped<IServiceBusManager, ServiceBusManager>();

            return services;
        }
    }
}
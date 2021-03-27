namespace AzureServiceBusViewer.Application.Contracts
{
    public sealed class Resource
    {
        public string Name { get; set; }
        public ResourceType Type { get; set; }
        public long MessageCount { get; set; }
        public long DeadLetterCount { get; set; }
    }

    public enum ResourceType : byte
    {
        Undefined = 0,
        Queue = 1,
        Topic = 2
    }
}
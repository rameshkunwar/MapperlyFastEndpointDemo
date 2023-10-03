namespace FastEndpointsDemo.SignalR
{
    public interface IMessageClient
    {
        Task ReceiveMessage(string user, string message);
        Task<string> GetMessage();

    }
}

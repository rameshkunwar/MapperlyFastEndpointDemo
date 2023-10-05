using MapperlyTestForMapping.DTO;

namespace FastEndpointsDemo.SignalR
{
    public interface IMessageClient
    {
        Task ReceiveMessage(string user, string message);
        Task<string> GetMessage();

        Task BroadcastMessage(BegivenhederDto begivenhederDto);
    }
}

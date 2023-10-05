using MapperlyTestForMapping.DTO;
using Microsoft.AspNetCore.SignalR;

namespace FastEndpointsDemo.SignalR
{
    public class OrderHub : Hub<IMessageClient>
    {
        public async Task SendMessage(string user, string message)
        {
            await Clients.All.ReceiveMessage(user, message);
        }

        public async Task<string> WaitForMessage(string connectionId)
        {
            string message = await Clients.Client(connectionId).GetMessage();
            return message;
        }

        public async Task PushBegivenhederToClients(BegivenhederDto begivenhederDto)
        {
            await Clients.All.BroadcastMessage(begivenhederDto);
        }
    }
}

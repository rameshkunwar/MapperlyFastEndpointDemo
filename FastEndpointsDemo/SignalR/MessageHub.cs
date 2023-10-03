using Microsoft.AspNetCore.SignalR;

namespace FastEndpointsDemo.SignalR
{
    public class MessageHub : Hub<IMessageClient>
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
    }
}

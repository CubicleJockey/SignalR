using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;

namespace Tutorial.Hubs
{
    [HubName("chat")]
    public class ChatHub : Hub
    {
        public void Send(string name, string message)
        {
            Clients.All.sendMessageToPage(name, message);
        }
    }
}
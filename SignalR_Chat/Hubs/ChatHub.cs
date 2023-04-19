using Microsoft.AspNetCore.SignalR;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SignalR_Chat.Hubs
{
    public class ChatHub : Hub                                      
    {
        public async Task SendMessage (string user, string message)
        {
            await Clients.All.SendAsync ("ReceiveMessage", user, message);
        }
    }

    /*
        A hub is a class that serves as a high-level pipeline that handles client-server communication.
        The ChatHub class inherits from the SignalR Hub class. The Hub class manages connections, groups, and messaging.
        The SendMessage method can be called by a connected client to send a message to all clients.
        JavaScript client code that calls the method is shown later in the tutorial.SignalR code is asynchronous to provide maximum scalability.
    */
}

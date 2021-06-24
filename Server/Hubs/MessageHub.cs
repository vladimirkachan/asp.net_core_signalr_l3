using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace Server.Hubs
{
    public class MessageHub : Hub<IMessageClient>
    {
        public Task SendToOthers(Message message)
        {
            var messageForClient = NewMessage.Create(Context.Items["Name"] as string, message);
            return Clients.Others.Send(messageForClient);
        }
        public Task SetName(string name)
        {
            if (!string.IsNullOrWhiteSpace(name)) Context.Items["Name"] = name;
            return Task.CompletedTask;
        }
        public Task<string> GetName()
        {
            var items = Context.Items;
            return Task.FromResult(items.ContainsKey("Name") ? items["Name"] as string : "Anonymous");
        }
    }
}

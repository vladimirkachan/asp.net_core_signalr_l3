using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public sealed class NewMessage : Message
    {
        public string Sender {get; set;}
        NewMessage() {}
        public static NewMessage Create(string sender, Message message)
        {
            return new() {Sender = string.IsNullOrWhiteSpace(sender) ? "Anonymous" : sender, Text = message.Text};
        }
    }
}

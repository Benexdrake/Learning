using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twitch_Bot
{
    public struct ChatEntry
    {
        public string Sender { get; set; }
        public string Message { get; set; }

        public ChatEntry(string _Sender, string _Message)
        {
            Sender = _Sender;
            Message = _Message;
        }
    }
}

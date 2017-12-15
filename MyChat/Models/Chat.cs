using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyChat.Models
{
    public class Chat : Hub
    {
        public Task SendMessage(string nickname, int roomId, string message)
        {
            return Clients.All.InvokeAsync("GetMessage", nickname, roomId, message);
        }
    }
}

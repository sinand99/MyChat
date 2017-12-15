using MyChat.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyChat.Models
{
    public class ChatRoomManager : IChatRoomManager
    {
        public List<ChatRoom> RoomList { get; set; }

        public ChatRoomManager()
        {
            RoomList = new List<ChatRoom>();
        }
    }
}

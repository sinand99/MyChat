using MyChat.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyChat.Interfaces
{
    public interface IChatRoomManager
    {
        List<ChatRoom> RoomList { get; set; }
    }
}

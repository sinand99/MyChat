using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyChat.Models
{
    public class ChatRoom
    {
        public int Id { get; set; }
        public string Name { get { return $"Room {Id}";  } }
    }
}

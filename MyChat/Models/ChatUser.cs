using MyChat.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyChat.Models
{
    public class ChatUser : IUser
    {
        [Required(ErrorMessage = "Please enter a nickname!")]
        public string Nickname { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyChat.Interfaces;
using MyChat.Models;

namespace MyChat.Controllers
{
    public class ChatController : Controller
    {
        private readonly IChatRoomManager _chatRoomManager;

        public ChatController(IChatRoomManager chatRoomManager)
        {
            _chatRoomManager = chatRoomManager;
        }

        public IActionResult Index(int id)
        {
            ChatRoom room = _chatRoomManager.RoomList.FirstOrDefault(r => r.Id == id);
            ViewData["Nickname"] = HttpContext.Session.GetString("Nickname");
            return View(room);
        }
    }
}
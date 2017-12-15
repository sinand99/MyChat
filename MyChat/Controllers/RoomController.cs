using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyChat.Interfaces;
using MyChat.Models;
using Microsoft.AspNetCore.Http;

namespace MyChat.Controllers
{
    public class RoomController : Controller
    {

        private readonly IChatRoomManager _chatRoomManager;

        public RoomController(IChatRoomManager chatRoomManager)
        {
            _chatRoomManager = chatRoomManager;
        }

        public IActionResult Index()
        {
            string nickname = HttpContext.Session.GetString("Nickname");
            ViewData["Nickname"] = nickname;

            return View(_chatRoomManager);
        }

        public IActionResult Create()
        {
            int id = _chatRoomManager.RoomList.Count + 1;
            _chatRoomManager.RoomList.Add(new ChatRoom() { Id = id });
            return RedirectToAction("Index", "Chat", new { id = id });
        }

        public IActionResult Join(int id)
        {
            return RedirectToAction("Index", "Chat", new { id = id });
        }
    }
}
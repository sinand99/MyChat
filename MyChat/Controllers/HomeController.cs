using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyChat.Interfaces;
using MyChat.Models;

namespace MyChat.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(new ChatUser());
        }

        [HttpPost]
        public IActionResult Index(ChatUser user)
        {
            HttpContext.Session.SetString("Nickname", user.Nickname);
            return RedirectToAction("Index", "Room");
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

﻿using Microsoft.AspNetCore.Mvc;

namespace ChatAPP.Controllers
{
    public class ChatController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

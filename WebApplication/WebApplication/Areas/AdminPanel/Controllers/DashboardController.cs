﻿using Microsoft.AspNetCore.Mvc;

namespace WebApplication.Areas.AdminPanel.Controllers
{
    public class DashboardController : Controller
    {
        [Area("AdminPanel")]

        public IActionResult Index()
        {

            return View();
        }
    }
}

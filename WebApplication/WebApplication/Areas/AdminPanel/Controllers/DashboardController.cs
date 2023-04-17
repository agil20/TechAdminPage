﻿using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

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

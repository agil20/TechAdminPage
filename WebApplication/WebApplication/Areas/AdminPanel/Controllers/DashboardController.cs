using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebApplication.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    public class DashboardController : Controller
    {
       

        public IActionResult Index()
        {
            
            return View();
        }
        public async Task<IActionResult> GetMMS()
        {

            return View();
        }

    }
}

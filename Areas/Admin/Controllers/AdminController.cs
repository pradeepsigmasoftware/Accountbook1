using Microsoft.AspNetCore.Mvc;

namespace Accountbook.Areas.Admin.Controllers
{
    [Area("admin")]
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Dashboard()
        {
            return View();
        }
    }
}

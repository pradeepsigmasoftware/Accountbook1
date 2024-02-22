using Microsoft.AspNetCore.Mvc;

namespace Accountbook.Areas.Admin.Controllers
{
    [Area("admin")]
    public class MasterController : Controller
    {
        public IActionResult CreateUnit()
        {
            return View();
        }
    }
}

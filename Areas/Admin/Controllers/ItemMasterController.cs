using Microsoft.AspNetCore.Mvc;

namespace Accountbook.Areas.Admin.Controllers
{
    [Area("admin")]
    public class ItemMasterController : Controller
    {
        public IActionResult CreateItemGroup()
        {
            return View();
        }
        public IActionResult CreateItemHead()
        {
            return View();
        }
    }
}

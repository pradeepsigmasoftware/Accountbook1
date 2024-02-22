using Microsoft.AspNetCore.Mvc;

namespace Accountbook.Areas.Admin.Controllers
{
    [Area("admin")]
    public class LedgerController : Controller
    {
        public IActionResult CreateGroup()
        {
            return View();
        }
        public IActionResult CreateLedger()
        {
            return View();
        }
    }
}

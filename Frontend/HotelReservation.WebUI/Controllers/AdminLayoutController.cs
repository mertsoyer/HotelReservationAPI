using Microsoft.AspNetCore.Mvc;

namespace HotelReservation.WebUI.Controllers
{
    public class AdminLayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult _AdminLayout()
        {
            return View();
        }

        public IActionResult HeadPartial()
        {
            return PartialView();
        }

        public IActionResult PreLoaderPartial()
        {
            return PartialView();
        }
        public IActionResult NavHeaderPartial()
        {
            return PartialView();
        }
        public IActionResult HeaderPartial()
        {
            return PartialView();
        }
        public IActionResult SidebarPartial()
        {
            return PartialView();
        }
    }
}

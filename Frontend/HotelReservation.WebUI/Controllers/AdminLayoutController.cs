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
    }
}

using Microsoft.AspNetCore.Mvc;

namespace HotelReservation.WebUI.Controllers
{
    public class StaffController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

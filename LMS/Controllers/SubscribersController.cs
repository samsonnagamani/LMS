using Microsoft.AspNetCore.Mvc;

namespace LMS.Controllers
{
    public class SubscribersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
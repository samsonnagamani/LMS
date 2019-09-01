using Microsoft.AspNetCore.Mvc;

namespace LMS.Controllers
{
    public class BranchesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
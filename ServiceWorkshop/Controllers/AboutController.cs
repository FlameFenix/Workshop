using Microsoft.AspNetCore.Mvc;

namespace ServiceWorkshop.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

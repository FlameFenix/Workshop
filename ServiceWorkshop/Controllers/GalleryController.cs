using Microsoft.AspNetCore.Mvc;

namespace ServiceWorkshop.Controllers
{
    public class GalleryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

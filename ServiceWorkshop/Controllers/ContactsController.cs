using Microsoft.AspNetCore.Mvc;

namespace ServiceWorkshop.Controllers
{
    public class ContactsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

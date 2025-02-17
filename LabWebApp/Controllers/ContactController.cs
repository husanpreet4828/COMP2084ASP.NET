using Microsoft.AspNetCore.Mvc;

namespace LabWebApp.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

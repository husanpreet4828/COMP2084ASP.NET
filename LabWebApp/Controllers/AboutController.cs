using Microsoft.AspNetCore.Mvc;

namespace LabWebApp.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

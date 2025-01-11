using Microsoft.AspNetCore.Mvc;

namespace Portfolyom.Controllers
{
    public class LayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

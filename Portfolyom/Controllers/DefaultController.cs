using Microsoft.AspNetCore.Mvc;

namespace Portfolyom.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

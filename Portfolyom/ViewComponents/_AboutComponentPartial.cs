using Microsoft.AspNetCore.Mvc;

namespace Portfolyom.ViewComponents
{
    public class _AboutComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

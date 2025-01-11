using Microsoft.AspNetCore.Mvc;

namespace Portfolyom.ViewComponents
{
    public class _HeadComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

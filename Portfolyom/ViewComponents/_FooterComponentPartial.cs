using Microsoft.AspNetCore.Mvc;

namespace Portfolyom.ViewComponents
{
    public class _FooterComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

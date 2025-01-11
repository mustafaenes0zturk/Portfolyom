using Microsoft.AspNetCore.Mvc;

namespace Portfolyom.ViewComponents.LayoutViewComponent
{
    public class _LayoutSideBarComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

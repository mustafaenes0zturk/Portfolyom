using Microsoft.AspNetCore.Mvc;

namespace Portfolyom.ViewComponents.LayoutViewComponent
{
    public class _LayoutHeadComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke() 
        {
            return View(); 
        }
    }
}

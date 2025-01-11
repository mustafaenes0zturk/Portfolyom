using Microsoft.AspNetCore.Mvc;

namespace Portfolyom.ViewComponents
{
    public class _ContactComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke() 
        {  
            return View(); 
        }
    }
}

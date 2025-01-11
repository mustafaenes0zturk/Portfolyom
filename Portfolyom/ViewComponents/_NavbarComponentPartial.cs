using Microsoft.AspNetCore.Mvc;

namespace Portfolyom.ViewComponents
{
    public class _NavbarComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke() 
        {  
            return View(); 
        }    
    }
}

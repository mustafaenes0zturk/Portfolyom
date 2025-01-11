using Microsoft.AspNetCore.Mvc;

namespace Portfolyom.ViewComponents
{
    public class _SkillComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke() 
        {  
            return View(); 
        }
    }
}

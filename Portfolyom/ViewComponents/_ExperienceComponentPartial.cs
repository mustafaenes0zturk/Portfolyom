using Microsoft.AspNetCore.Mvc;
using Portfolyom.DAL.Context;

namespace Portfolyom.ViewComponents
{
    public class _ExperienceComponentPartial : ViewComponent
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public IViewComponentResult Invoke() 
        {  
            var values = context.Experiences.ToList();
            return View(values); 
        }
    }
}

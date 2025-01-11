using Microsoft.AspNetCore.Mvc;
using Portfolyom.DAL.Context;

namespace Portfolyom.ViewComponents
{
    public class _FeatureComponentPartial : ViewComponent
    {
        MyPortfolioContext portfolioContext = new MyPortfolioContext();
        public IViewComponentResult Invoke() 
        {
            var values = portfolioContext.Features.ToList();
            return View(values); 
        }
    }
}

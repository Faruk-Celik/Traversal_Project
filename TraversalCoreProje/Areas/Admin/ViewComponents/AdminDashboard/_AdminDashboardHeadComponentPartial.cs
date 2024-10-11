using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.Areas.Admin.ViewComponents.AdminDashboard
{
    public class _AdminDashboardHeadComponentPartial:ViewComponent
    { 
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

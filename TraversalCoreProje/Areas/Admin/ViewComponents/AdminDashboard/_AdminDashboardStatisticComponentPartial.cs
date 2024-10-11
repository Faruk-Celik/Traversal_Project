using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace TraversalCoreProje.Areas.Admin.ViewComponents.AdminDashboard
{
    public class _AdminDashboardStatisticComponentPartial : ViewComponent
    {   
        Context c= new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.v1 = c.Destinations.Count(); 
            ViewBag.v2 = c.Users.Count(); 
            ViewBag.v3=c.Destinations.Sum(x =>x.Capacity);
            return View();  
        }
    }
}

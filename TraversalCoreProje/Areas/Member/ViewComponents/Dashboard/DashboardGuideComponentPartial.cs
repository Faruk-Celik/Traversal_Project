using BussinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.Areas.Member.ViewComponents.Dashboard
{    
    public class DashboardGuideComponentPartial:ViewComponent
    {
        GuideManage guideManager = new GuideManage(new EfGuideDal());
        public IViewComponentResult Invoke()
        { 
            var values=guideManager.TGetList();
             return View(values);
        }
    }
}

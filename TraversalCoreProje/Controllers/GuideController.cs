using BussinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.Controllers
{
    [AllowAnonymous]
    public class GuideController : Controller
    {
        GuideManage guideManage = new GuideManage(new EfGuideDal());
        public IActionResult Index()
        { 
            var values=guideManage.TGetList();
            return View(values);
        }
    }
}

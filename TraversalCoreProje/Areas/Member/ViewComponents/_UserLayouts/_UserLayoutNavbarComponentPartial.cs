using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.Areas.Member.ViewComponents._UserLayouts
{
    public class _UserLayoutNavbarComponentPartial:ViewComponent
    { 
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

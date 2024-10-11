using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.Areas.Member.ViewComponents._UserLayouts
{
    public class _UserLayoutFooterComponentPartial:ViewComponent
    { 
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

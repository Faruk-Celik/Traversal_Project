using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.Areas.Member.ViewComponents._UserLayouts
{
    public class _UserLayoutScriptsComponentPartial:ViewComponent
    { 
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

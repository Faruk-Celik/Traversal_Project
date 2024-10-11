using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.Areas.Admin.ViewComponents.Layout
{
    public class _AdminLayoutFooterComponentPartial:ViewComponent
    { 
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

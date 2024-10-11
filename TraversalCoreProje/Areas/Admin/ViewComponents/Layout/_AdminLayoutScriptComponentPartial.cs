using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.Areas.Admin.ViewComponents.Layout
{
    public class _AdminLayoutScriptComponentPartial:ViewComponent
    { 
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

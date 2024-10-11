using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.Areas.Admin.ViewComponents.Layout
{
    public class _AdminLayoutHeadComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    

    }
}

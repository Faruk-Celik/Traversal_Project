using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.ViewComponents.UILayout
{
    public class _UIFooterLayoutPartialComponent:ViewComponent
    { 
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

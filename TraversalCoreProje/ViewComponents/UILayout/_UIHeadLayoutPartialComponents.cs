using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.ViewComponents.UILayout
{
    public class _UIHeadLayoutPartialComponents:ViewComponent
    { 
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.ViewComponents.Default
{
    public class _DefaultSliderComponentPartial:ViewComponent
    { 
        public IViewComponentResult Invoke()
        {
            return View();

        }
    }
}

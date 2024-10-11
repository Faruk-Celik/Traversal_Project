using BussinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.ViewComponents.Destination
{
    public class _DestinationGuideDetailComponentPartial:ViewComponent
    { 
        private readonly IGuideService _guideService;

        public _DestinationGuideDetailComponentPartial(IGuideService guideService)
        {
            _guideService = guideService;
        } 
        public IViewComponentResult Invoke(int id)
        {
            var values = _guideService.TGetById(2); 
            return View(values);
        }
    }
}

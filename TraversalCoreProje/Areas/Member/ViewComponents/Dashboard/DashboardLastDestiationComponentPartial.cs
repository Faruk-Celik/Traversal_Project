using BussinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.Areas.Member.ViewComponents.Dashboard
{
    public class DashboardLastDestiationComponentPartial:ViewComponent
    {  
        private readonly IDestinationService _destinationService;

        public DashboardLastDestiationComponentPartial(IDestinationService destinationService)
        {
            _destinationService = destinationService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _destinationService.TGetLast4Destinations();
            return View(values);
        }
    }
}

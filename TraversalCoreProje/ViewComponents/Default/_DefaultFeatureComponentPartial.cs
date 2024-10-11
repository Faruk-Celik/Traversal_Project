using BussinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.ViewComponents.Default
{
    public class _DefaultFeatureComponentPartial : ViewComponent
    {
        FeatureManager featureManager = new FeatureManager(new EfFeatureDal());
        public IViewComponentResult Invoke()
        {
            //ViewBag.ımage1=
            return View();
        }
    }
}

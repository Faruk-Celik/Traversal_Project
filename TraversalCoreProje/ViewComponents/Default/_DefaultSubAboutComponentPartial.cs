using BussinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.ViewComponents.Default
{
    public class _DefaultSubAboutComponentPartial:ViewComponent 
    {
        SubAboutManager subAboutManager = new SubAboutManager(new EfSubAboutDal());
        public IViewComponentResult Invoke()
        { 
            var values=subAboutManager.TGetList();
            return View(values);
        }
    }
}

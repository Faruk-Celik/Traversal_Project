using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace TraversalCoreProje.Areas.Member.ViewComponents.Dashboard
{
    public class DashboardInformationComponentPartial:ViewComponent
    {   
        private readonly UserManager<AppUser> _userManager;

        public DashboardInformationComponentPartial(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {  
            var user= await _userManager.FindByNameAsync(User.Identity.Name); 
            ViewBag.namesurname=user.Name + " " + user.Surname; 
            ViewBag.email=user.Email; 
            ViewBag.phoneNumber=user.PhoneNumber;
            return View();
        }
    }
}

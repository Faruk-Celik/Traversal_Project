using BussinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace TraversalCoreProje.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AllowAnonymous]
    public class UserController : Controller
    { 
        private readonly IAppUserService _appUserService;
        private readonly IReservationService _reservationService; 
        
        public UserController(IAppUserService appUserService, IReservationService reservationService, UserManager<AppUser> userManager)
        {
            _appUserService = appUserService;
            _reservationService = reservationService;
         
        }

        public IActionResult Index()
        { 
            var values=_appUserService.TGetList();
            return View(values);
        } 

        public IActionResult ReservationUser(int id)
        {   
          
            var values= _reservationService.TGetListWithReservationByAccepted(id); 
            return View(values);
        }
    }
}

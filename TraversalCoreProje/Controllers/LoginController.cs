using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TraversalCoreProje.Models;

namespace TraversalCoreProje.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        public LoginController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult SingUp()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> SingUp(UserRegisterViewModel p)
        {
            AppUser appUser = new AppUser()
            {
                Name = p.Name,
                Surname = p.Surname,
                Mail = p.Mail,
                UserName = p.Username,
            };
            if (p.Password == p.ConfirmPassWord)
            {
                var result = await _userManager.CreateAsync(appUser, p.Password);
                if (result.Succeeded)
                {
                    return RedirectToAction("SignIn");

                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }
            }
            return View();
        }
        [HttpGet]
        public IActionResult SignIn()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SignIn(UserSignInViewModel p)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(p.Usurname, p.Password, false, true);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Profile", new { area = "Member" });
                }
                else
                {
                    return RedirectToAction("SigIn", "Login");

                }

            }
            return View();
        }

    }
}

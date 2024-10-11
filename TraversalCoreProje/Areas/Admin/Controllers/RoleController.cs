
using DocumentFormat.OpenXml.Office2010.ExcelAc;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TraversalCoreProje.Areas.Admin.Models;

namespace TraversalCoreProje.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/Role")]
    public class RoleController : Controller
    {
        private readonly RoleManager<AppRole> _roleManger;
        private readonly UserManager<AppUser> _userManager;
        public RoleController(RoleManager<AppRole> roleManger, UserManager<AppUser> userManager)
        {
            _roleManger = roleManger;
            _userManager = userManager;
        }
        [Route("Index")]

        public IActionResult Index()
        {
            var values = _roleManger.Roles.ToList();
            return View(values);
        }
        [HttpGet]
        [Route("CreateRole")]
        public IActionResult CreateRole()
        {
            return View();
        }
        [HttpPost]
        [Route("CreateRole")]

        public async Task<IActionResult> CreateRole(CreateViewModel model)
        {
            AppRole role = new AppRole()
            {
                Name = model.RoleName

            };
            var result = await _roleManger.CreateAsync(role);
            if (result.Succeeded)
            {
                return RedirectToAction("Index");
            }
            return View();
        }

        [Route("DeleteRole/{id}")]
        public async Task<IActionResult> DeleteRole(int id)
        {
            var value = _roleManger.Roles.FirstOrDefault(x => x.Id == id);
            await _roleManger.DeleteAsync(value);
            return RedirectToAction("Index");
        }
        [HttpGet]
        [Route("UpdateRole/{id}")]
        public async Task<IActionResult> UpdateRole(int id)
        {
            var value = _roleManger.Roles.FirstOrDefault(x => x.Id == id);
            UpdateRoleViewModel updateRoleViewModel = new UpdateRoleViewModel
            {
                RoleId = value.Id,
                RoleName = value.Name
            };
            return View(updateRoleViewModel);
        }
        [HttpPost]
        [Route("UpdateRole/{id}")]
        public async Task<IActionResult> UpdateRole(UpdateRoleViewModel model)
        {
            var value = _roleManger.Roles.FirstOrDefault(x => x.Id == model.RoleId);
            value.Name = model.RoleName;
            await _roleManger.UpdateAsync(value);
            return RedirectToAction("Index");
        }
        [Route("UserList")]
        public IActionResult UserList()
        {
            var values = _userManager.Users.ToList();
            return View(values);
        }

        [Route("AssignRole/{id}")]
        public async Task<IActionResult> AssignRole(int id)
        {
            var user = _userManager.Users.FirstOrDefault(x => x.Id == id);
            var roles = _roleManger.Roles.ToList();
            var userRoles = await _userManager.GetRolesAsync(user);
            List<RoleAssingViewModel> roleAssingViewModels = new List<RoleAssingViewModel>();
            foreach (var item in roles)
            {
                RoleAssingViewModel model = new RoleAssingViewModel();
                model.RoleId = item.Id;
                model.RoleName = item.Name;
                model.RoleExist = userRoles.Contains(item.Name);
                roleAssingViewModels.Add(model);
            }
            return View(roleAssingViewModels);
        }
        [HttpPost]
        [Route("AssignRole/{id}")]
        public async Task<IActionResult> AssignRole(List<RoleAssingViewModel> model)
        {
            var userId = (int)TempData["userid"];
            var user = _userManager.Users.FirstOrDefault(x => x.Id == userId);

            foreach (var item in model)
            {
                if (item.RoleExist)
                {
                    await _userManager.AddToRoleAsync(user, item.RoleName);
                }
                else
                {
                    await _userManager.RemoveFromRoleAsync(user, item.RoleName);
                }
            }
            return RedirectToAction("UserList");
        }
    }
}

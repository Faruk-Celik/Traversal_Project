using BussinessLayer.Abstract;
using BussinessLayer.ValidationRules;
using DocumentFormat.OpenXml.Office.CustomUI;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/Guide")]
    [AllowAnonymous]
    public class GuideController : Controller
    {
        private readonly IGuideService _guideservice;

        public GuideController(IGuideService guideservice)
        {
            _guideservice = guideservice;
        }
        [Route("Index")]
        public IActionResult Index()
        {
            var values = _guideservice.TGetList();
            return View(values);
        }
        [Route("AddGuide")]
        [HttpGet]
        public IActionResult AddGuide() { return View(); }
        [Route("AddGuide")]
        [HttpPost]
        public IActionResult AddGuide(Guide p)
        {
            GuideValidator validationRules = new GuideValidator();
            ValidationResult result = validationRules.Validate(p);
            if (result.IsValid)
            {
                _guideservice.TAdd(p);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
        [Route("ChangeToTrue/{id}")]
        public IActionResult ChangeToTrue(int id)
        {
            _guideservice.TChangeToTrue(id);
            return RedirectToAction("Index", "Guide", new { area = "Admin" });
        }
        [Route("ChangeToFalse/{id}")]
        public IActionResult ChangeToFalse(int id)
        {
            _guideservice.TChangeToFalseGuide(id);
            return RedirectToAction("Index", "Guide", new { area = "Admin" });

        }
    }
}

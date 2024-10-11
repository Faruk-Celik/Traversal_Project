using BussinessLayer.Abstract;
using BussinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AllowAnonymous]
    public class CommentController : Controller
    {
        private readonly ICommentService _commentservice;

        public CommentController(ICommentService commentservice)
        {
            _commentservice = commentservice;
        }

        public IActionResult Index()
        {
            var values = _commentservice.TGetCommentWithDestination();

            return View(values);
        }
        public IActionResult DeleteComment(int id)
        {
            _commentservice.TDelete(id);
            return RedirectToAction("Index");
        }
    }
}

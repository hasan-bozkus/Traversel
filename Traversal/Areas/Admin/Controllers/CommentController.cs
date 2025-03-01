using BusinnesLayer.Abtstract;
using BusinnesLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Traversal.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("[area]/[controller]/[action]")]
    public class CommentController : Controller
    {
        private readonly ICommentService _commentService;

        public CommentController(ICommentService commentService)
        {
            _commentService = commentService;
        }

        public IActionResult Index()
        {
            var values = _commentService.TGetListCommentWithDestinaiton();
            return View(values);
        }

        public IActionResult DeleteComment(int id)
        {
            var result = _commentService.TGetByID(id);
            _commentService.TDelete(result);
            return RedirectToAction("Index", new { areas = "Admin"});
        }
    }
}

using BusinnesLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Traversal.ViewComponents.Comment
{
    public class _CommentList : ViewComponent
    {
        CommentManager commentManager = new CommentManager(new EFCommentDal());

        public IViewComponentResult Invoke(int id)
        {
            ViewBag.commentCount = commentManager.TGetListCommentWithDestinationAndUser(id).Count;
            var values = commentManager.TGetListCommentWithDestinationAndUser(id);
            return View(values);
        }
    }
}

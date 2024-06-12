using Business.Abstract;
using Business.Concrete;
using Data.Concrete.EntityFramwork;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]/{id?}")]
    public class CommentController : Controller
    {
        private readonly ICommentService _commentService;
        
        public CommentController(ICommentService commentService)
        {
            _commentService = commentService;
          
        }

        public IActionResult Index()
        {
            var values = _commentService.GetCommentsWithDestinations();

            return View(values);
        }
        public IActionResult DeleteComment(int id)
        {
            var values = _commentService.GetById(id);
            _commentService.Delete(values);
            return RedirectToAction("Index", "Comment", new { area = "Admin" });
        }
            public IActionResult ApproveComment(int id)
        {
            var comment = _commentService.GetById(id);
            comment.State = true;
            _commentService.Update(comment);
            return RedirectToAction("Index", "Comment", new { area = "Admin" });
        }
    }
}

using Business.Abstract;
using Business.Concrete;
using Data.Concrete.EntityFramwork;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.ViewComponents.Comment
{
    
    public class _CommentList : ViewComponent
    {
        private readonly ICommentService _commentService;

        public _CommentList(ICommentService commentService)
        {
            _commentService = commentService;
        }

        public IViewComponentResult Invoke(int Id) {
            var values = _commentService.GetCommentsWithDestinationsandAppUser(Id);
            
            return View(values); 
        }
    }
}

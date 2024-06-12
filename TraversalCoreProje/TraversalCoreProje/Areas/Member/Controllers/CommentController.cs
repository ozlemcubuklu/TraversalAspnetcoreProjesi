using Business.Abstract;
using DocumentFormat.OpenXml.Office2010.Excel;
using Entity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace TraversalCoreProje.Areas.Member.Controllers
{
    [Area("Member")]
	[Route("Member/[controller]/[action]/{id?}")]
	public class CommentController : Controller
    {
        private readonly ICommentService _commentservice;
        private readonly UserManager<AppUser> _userManager;

        public CommentController(ICommentService commentservice, UserManager<AppUser> userManager)
        {
            _commentservice = commentservice;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            var values = _commentservice.GetCommentsWithDestinationsByAppUserId(user.Id);
            return View(values);
        }
        [HttpGet]
        public IActionResult UpdateComment(int id)
        {
            var values = _commentservice.GetById(id);
            if (values != null)
            {
                return View(values);
            }
            else return RedirectToAction("Index", "Comment", new { area = "Member" });

        }



        [HttpPost]
        public IActionResult UpdateComment(Comment comment)
		{

			var values = _commentservice.GetById(comment.Id);

            values.State = false;
            values.Content= comment.Content;
            _commentservice.Update(values);
            ViewBag.uyari = "İçerik Onaylandıktan sonra yorumunuz sistemde görünecektir.";
            return RedirectToAction("Index", "Comment", new { area = "Member" });
        }
        public IActionResult DeleteComment(int id)
        {
            var comment= _commentservice.GetById(id);
           
                _commentservice.Delete(comment);
                return RedirectToAction("Index", "Comment", new { area = "Member" });
            

        }
    }
}

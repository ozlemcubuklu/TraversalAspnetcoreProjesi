using Business.Abstract;
using Business.Concrete;
using Data.Concrete.EntityFramwork;
using Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp;
using System;
using System.Security.Cryptography.Xml;

namespace TraversalCoreProje.Controllers
{
    public class CommentController : Controller
    {
        ICommentService _commentService;
       

        public CommentController(ICommentService commentService)
        {
            _commentService = commentService;
        }

        [HttpGet]
        public PartialViewResult AddComment(int DestinationId)
        {
            ViewBag.i = DestinationId;
            return PartialView();
        }
        [HttpPost]
        public IActionResult AddComment(Comment comment)
        {
            comment.User=User.Identity.Name;
            comment.Date = Convert.ToDateTime(DateTime.Now.ToString());
            comment.State = false;
            _commentService.Insert(comment);
            return RedirectToAction("Index","Destination");
        }
    }
}

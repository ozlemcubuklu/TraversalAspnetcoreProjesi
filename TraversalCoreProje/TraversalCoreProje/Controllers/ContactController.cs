using Business.Abstract;
using DTO.DTOs.ContactUsDTOs;
using Entity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;

namespace TraversalCoreProje.Controllers
{
    [AllowAnonymous]
    public class ContactController : Controller
    {
        private readonly IContactUsService _contactUsService;

        public ContactController(IContactUsService contactUsService)
        {
            _contactUsService = contactUsService;
        }
        [HttpGet]
        public IActionResult Index()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Index(SendMessageDTO model)
        {
            if (ModelState.IsValid)
            {
                var values = new ContactUs() { Mail = model.Mail,
                    MessageBody = model.MessageBody,
                    Subject = model.Subject,
                    Name = model.Name,
                    MessageDate = Convert.ToDateTime(DateTime.Now.ToShortDateString()),
                    MessageStatus = true
                };
                _contactUsService.Insert(values);
                return RedirectToAction("Index","Default");
            }
            return View(model);
        }
    }
}

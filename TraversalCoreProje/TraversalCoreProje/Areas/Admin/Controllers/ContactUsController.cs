using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ContactUsController : Controller
    {
        private readonly IContactUsService _contactUsService;

        public ContactUsController(IContactUsService contactService)
        {
            _contactUsService = contactService;
        }

        public IActionResult Index()
        {
            var values=_contactUsService.GetListByTrue();
            return View(values);
        }
    }
}

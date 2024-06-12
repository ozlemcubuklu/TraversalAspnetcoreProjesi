using Business.Abstract;
using Business.Concrete;
using Data.Concrete.EntityFramwork;
using Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Server.IISIntegration;

namespace TraversalCoreProje.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]/{id?}")]
    public class DestinationController : Controller
    {
        private readonly IDestinationService _destinationService;

        public DestinationController(IDestinationService destinationService)
        {
            _destinationService = destinationService;
        }

        public IActionResult Index()
        {
            var values = _destinationService.GetAll();
            return View(values);
        }


        [HttpGet]
        public IActionResult AddDestination()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddDestination(Destination destination)
        {
            _destinationService.Insert(destination);
            return RedirectToAction("Index", "Destination", new { area = "Admin" });

        }
        [HttpGet]
        public IActionResult UpdateDestination(int id)
        {
            var values = _destinationService.GetById(id);
            return View(values);

        }

        [HttpPost]
        public IActionResult UpdateDestination(Destination destination)
        {
            _destinationService.Update(destination);
            return RedirectToAction("Index", "Destination", new { area = "Admin" });

        }

        public IActionResult DeleteDestination(int id)
        {
           var values=_destinationService.GetById(id);
            _destinationService.Delete(values);
            return RedirectToAction("Index", "Destination", new { area = "Admin" });
        }
    }
}

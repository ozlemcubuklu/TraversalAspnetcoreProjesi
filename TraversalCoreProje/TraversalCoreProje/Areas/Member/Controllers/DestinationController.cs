using Business.Abstract;
using Business.Concrete;
using Data.Concrete.EntityFramwork;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace TraversalCoreProje.Areas.Member.Controllers
{
    [Area("Member")]
    public class DestinationController : Controller
    {
        private readonly IDestinationService _destinationService;

        public DestinationController(IDestinationService destinationService)
        {
            _destinationService = destinationService;
        }

        public IActionResult Index()
        {
            ViewBag.carttitle = "Aktif Tur Listemiz";
           ViewBag.cartcontent= "Alanında Uzman rehberlerimiz eşliğinde Balkanlardan Orta Asyaya, Dogu Avrupadan Anadolunun Dört Bir Yanına en Uygun fiyatlarla sunduğumuz tur listemize ve tur detaylarına aşağıdaki tablodan ulaşabilirsiniz.";
			var values = _destinationService.GetAll();
            return View(values);
        }
        public IActionResult LastDestination()
        {
            ViewBag.carttitle = "Son Eklenen Turlarımız";
            ViewBag.cartcontent = "Alanında Uzman rehberlerimiz eşliğinde Balkanlardan Orta Asyaya, Dogu Avrupadan Anadolunun Dört Bir Yanına en Uygun fiyatlarla sunduğumuz tur listemize ve tur detaylarına aşağıdaki tablodan ulaşabilirsiniz.";
            var values = _destinationService.GetLast4DestinationList();
            return View(values);
        }
        public IActionResult GetCitiesSearchByName(string searchString) {
            ViewData["CurrentFilter"] = searchString;
            var deger = _destinationService.GetAll();
            var values = from x in _destinationService.GetAll() select x;
            if (!string.IsNullOrEmpty(searchString))
            {
                deger=deger.Where(x=>x.City.Contains(searchString)).ToList();
                values = values.Where(y=>y.City.Contains(searchString));
            }
            
            
            
            return View(deger);
        }
    }
}

using AspNetCoreWebApi.DAL;
using AspNetCoreWebApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System;
using System.Linq;

namespace AspNetCoreWebApi.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class VisitorController : ControllerBase
    {
        private readonly VisitorService _visitorService;

        public VisitorController(VisitorService visitorService)
        {
            _visitorService = visitorService;
        }


        [HttpGet]
        public IActionResult CreateVisitor() { 
        
        Random rastgele=new Random();
            Enumerable.Range(1, 10).ToList().ForEach(x =>
            {
                foreach (ECity city in Enum.GetValues(typeof(ECity)))
                {
                    var newVisitor = new Visitor
                    {
                        City = city,
                        CityVisitCount = rastgele.Next(100, 2000),
                        VisitDate = DateTime.Now.AddDays(x)
                    };
                    _visitorService.SaveVisitor(newVisitor).Wait();
                    System.Threading.Thread.Sleep(1000);
                }
            });
            return Ok("Ziyaretçiler Baaşarılı Bir Şekilde Eklendi.");
        }
    }
}

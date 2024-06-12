using Business.Abstract;
using DocumentFormat.OpenXml.Office2010.ExcelAc;
using DocumentFormat.OpenXml.Presentation;
using Entity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using TraversalCoreProje.Areas.Admin.Models;

namespace TraversalCoreProje.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CityController : Controller
    {
        private readonly IDestinationService _destinationService;

        public CityController(IDestinationService destinationService)
        {
            _destinationService = destinationService;
        }

        public static List<CityModel> CityList()
        {
            var list = new List<CityModel>()
            {
            new CityModel(){Id=1,Name="Üsküp",Country="Makedonya"},
            new CityModel(){Id=2,Name="Londra",Country="İngiltere"},
            new CityModel(){Id=3,Name="Roma",Country="İtalya"},

            };
            return list;
        }
        public IActionResult CityList1()
        {
            var cities = _destinationService.GetAll();
            var jsoncity = JsonConvert.SerializeObject(cities);
            return Json(jsoncity);
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddCityDestination([FromBody] Destination destination)
        {
            if (destination == null)
            {
                return BadRequest("Invalid data.");
            }

            destination.Status = false;
            _destinationService.Insert(destination);
            var values = JsonConvert.SerializeObject(destination);
            return Ok(values);
        }



        public IActionResult DeleteCityDestination([FromBody] DeleteCityRequest request)
        {
            if (request == null || request.Id == 0)
            {
                return BadRequest("Invalid data.");
            }
            var values = _destinationService.GetById(request.Id);
            _destinationService.Delete(values);
            return Ok(new { Message = "Şehir silindi." });
        }
        public class DeleteCityRequest
        {
            public int Id { get; set; }
        }

        public IActionResult GetById(int DestinationId)
        {
            var values = _destinationService.GetById(DestinationId);
            var result = JsonConvert.SerializeObject(values);

            return Json(result);
        }
        public IActionResult UpdateCity([FromBody] Destination destination)
        {

            if (destination == null || destination.Id==0)
            {
                return BadRequest("Invalid data.");
            }
            var values = _destinationService.GetById(destination.Id);
          
            values.Price = destination.Price;
            values.City = destination.City;
            values.DayNight = destination.DayNight;
            _destinationService.Update(values);
            var result = JsonConvert.SerializeObject(values);
            return Ok(result);
        }

    }
}

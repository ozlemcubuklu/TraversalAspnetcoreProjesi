
using Business.Abstract;
using Business.ValidationRules;
using Entity;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using TraversalCoreProje.ViewComponents.MemberDashboard;

namespace TraversalCoreProje.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]/{id?}")]
    public class GuideController : Controller
    {
        private readonly IGuideService _guideService;

        public GuideController(IGuideService guideService)
        {
            _guideService = guideService;
        }

        public IActionResult Index()
        {
            var values = _guideService.GetAll();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddGuide() {
            return View();
        }

        [HttpPost]
        public IActionResult AddGuide(Guide guide)
        {
            GuideValidator validationRules = new GuideValidator();
            var result =validationRules.Validate(guide);

            if (result.IsValid)
            {
               _guideService.Insert(guide);
                return RedirectToAction("Index", "Guide", new { area = "Admin" });
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName,item.ErrorMessage);
                }
                return View(guide);
            }
         
        }

        [HttpGet]
        public IActionResult UpdateGuide(int id) {
            var values=_guideService.GetById(id);
          
            return View(values);
           
            
        }

        [HttpGet]
        public IActionResult UpdateGuide(Guide guide)
        {

 return RedirectToAction("Index", "Guide", new { area = "Admin" });


        }


        public IActionResult DeleteGuide(int id) 
        {
            var values = _guideService.GetById(id);
            _guideService.Delete(values);

            return RedirectToAction("Index", "Guide", new { area = "Admin" });
        }

        public IActionResult ChangesToTrue(int id)
        {
            var values = _guideService.GetById(id);
            values.Status = true;
            _guideService.Update(values);
            return RedirectToAction("Index", "Guide", new { area = "Admin" });
        }
            public IActionResult ChangesToFalse(int id)
        {

            var values = _guideService.GetById(id);
            values.Status = false;
            _guideService.Update(values);
            return RedirectToAction("Index", "Guide", new { area = "Admin" });
        }
        public IActionResult ChangeToStatus(int id)
        {
            _guideService.ChangeToStatus(id);
            return RedirectToAction("Index", "Guide", new { area = "Admin" });
        }
    }
}

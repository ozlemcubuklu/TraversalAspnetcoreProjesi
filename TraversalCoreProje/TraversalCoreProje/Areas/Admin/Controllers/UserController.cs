using Business.Abstract;
using Entity;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http.Headers;

namespace TraversalCoreProje.Areas.Admin.Controllers
{ [Area("Admin")]
    [Route("Admin/[controller]/[action]/{id?}")]
    public class UserController : Controller
    {
        private readonly IAppUserService _appUserService;
        private readonly IReservationService _reservationService;

        public UserController(IAppUserService appUserService, IReservationService reservationService)
        {
            _appUserService = appUserService;
            _reservationService = reservationService;
        }

        public IActionResult Index()
        {
            var values = _appUserService.GetAll();
            return View(values);
        }
        public IActionResult DeleteUser(int id)
        {
            var values = _appUserService.GetById(id);
            _appUserService.Delete(values);
            return RedirectToAction("Index", "User", new { area = "Admin" });


        }
        [HttpGet]
        public IActionResult UpdateUser(int id)
        {
            var values = _appUserService.GetById(id);
            
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateUser(AppUser user)
        {
            
            _appUserService.Update(user);
            return RedirectToAction("Index", "User", new { area = "Admin" });
        }


        public IActionResult ReservationUser(int id) {

            var reservation = _reservationService.GetListReservationsByAccepted( id);
            return View(reservation);
        
        }


    }
}

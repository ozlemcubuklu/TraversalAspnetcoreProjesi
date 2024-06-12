using Business.Abstract;
using Business.Concrete;
using Data.Concrete.EntityFramwork;
using Entity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCoreProje.Areas.Member.Controllers
{
    [Area("Member")]
    public class ReservationController : Controller
    {

        private readonly IDestinationService _destinationService;
        private readonly UserManager<AppUser> _userManager;

private readonly IReservationService _reservationService;
        public ReservationController(IReservationService reservationManager, IDestinationService destinationService, UserManager<AppUser> userManager)
        {
            _reservationService = reservationManager;
            _destinationService = destinationService;
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult NewReservation()
        {
            ViewBag.carttitle = "Yeni Rezervasyon";
            ViewBag.cartcontent = "Alanında Uzman rehberlerimiz eşliğinde Balkanlardan Orta Asyaya, Dogu Avrupadan Anadolunun Dört Bir Yanına en Uygun fiyatlarla sunduğumuz turlarımıza aşagıdaki formu doldurarak kayıt olabilirsiniz.";

            List<SelectListItem>values=(from x in _destinationService.GetAll()
                                        select new SelectListItem { Text=x.City,Value=x.Id.ToString()}).ToList();
            ViewBag.v=values;
            
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> NewReservation(Reservation p)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            p.AppUserId = user.Id;
            p.Status = "Onay Bekliyor";
          _reservationService.Insert(p);
           
            return RedirectToAction("MyCurrentReservation");
        }
        public async Task<IActionResult> MyCurrentReservation()
        {
            ViewBag.carttitle = "Aktif Rezervasyonlarım";
            ViewBag.cartcontent = "";

            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.v = values.Id;
            var valuesList = _reservationService.GetListReservationsByAccepted(values.Id);
            return View(valuesList);
        }
        public  async Task<IActionResult> MyOldReservation()
        {
            ViewBag.carttitle = "Geçmiş Rezervasyonlarım";
            ViewBag.cartcontent = "";

            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.v = values.Id;
            var valuesList = _reservationService.GetListReservationsByPrevious(values.Id);
            return View(valuesList);
        }
        public async Task<IActionResult> MyApprovalReservation()
        {
            ViewBag.carttitle = "Onaylanan Rezervasyonlarım";
            ViewBag.cartcontent = "";

            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.v=values.Id;
            var valuesList = _reservationService.GetListReservationsByWaitApproval(values.Id);
            return View(valuesList);
        }
    }
}

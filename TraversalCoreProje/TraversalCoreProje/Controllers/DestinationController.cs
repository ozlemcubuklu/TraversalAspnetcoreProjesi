using Business.Abstract;
using Business.Concrete;
using Data.Concrete.EntityFramwork;
using Entity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace TraversalCoreProje.Controllers
{
    [AllowAnonymous]
    public class DestinationController : Controller
    {private readonly UserManager<AppUser> _userManager;
        private readonly IDestinationService _destinationService;

        public DestinationController(UserManager<AppUser> userManager, IDestinationService destinationService)
        {
            _userManager = userManager;
            _destinationService = destinationService;
        }

        public IActionResult Index()
        {
            var value = _destinationService.GetAll();
            return View(value);
        }

        [HttpGet]
        public async Task<IActionResult> Details(int Id)
        {
            if (User.Identity.IsAuthenticated)
            {
                var user = await _userManager.FindByNameAsync(User.Identity.Name);  ViewBag.UserId=user.Id;
            }
          
            ViewBag.i = Id; 
            var values= _destinationService.GetDestinationwithGuide(Id);

            return View(values);
        }
        public IActionResult Last4Destination()
        {var values=_destinationService.GetLast4DestinationList();
            return View(values);
        }
    }
}

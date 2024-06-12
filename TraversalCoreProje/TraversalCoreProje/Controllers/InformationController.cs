using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;

namespace TraversalCoreProje.Controllers
{
	public class InformationController : Controller
	{
        private readonly IStringLocalizer<InformationController> _localizer;

        public InformationController(IStringLocalizer<InformationController> localizer)
        {
            _localizer = localizer;
        }

        public IActionResult Index()
		{
            ViewData["Merhaba"] = _localizer["Merhaba"];
			return View();
		}
	}
}

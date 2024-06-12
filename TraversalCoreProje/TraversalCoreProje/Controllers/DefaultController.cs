using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;

namespace TraversalCoreProje.Controllers
{
    [AllowAnonymous]
    public class DefaultController : Controller
    {
        private readonly ILogger<DefaultController> _logger;

        public DefaultController(ILogger<DefaultController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            DateTime date = Convert.ToDateTime(DateTime.Now.ToLongDateString());
            _logger.LogInformation(date+"default home sayfası çagırıdı..");
            return View();
        }
    }
}

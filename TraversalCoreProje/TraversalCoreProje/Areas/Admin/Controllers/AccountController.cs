using Business.Abstract.UOW;
using Entity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TraversalCoreProje.Areas.Admin.Models;

namespace TraversalCoreProje.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]/{id?}")]
    public class AccountController : Controller
    {
        private readonly IAccountService _accountService;

        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(AccountViewModel account)
        {
            if (account != null) {
                var gonderen = _accountService.GetById(account.SenderId);
                var alici=_accountService.GetById(account.ReceiverId);

                gonderen.Balance -= account.Amount;

                alici.Balance += account.Amount;

                _accountService.MultiUpdate(new List<Account>() { gonderen,alici});
            }
            return View(account);
        }
        }
}

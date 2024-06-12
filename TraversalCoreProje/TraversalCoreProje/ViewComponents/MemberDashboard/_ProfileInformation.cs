﻿using Entity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace TraversalCoreProje.ViewComponents.MemberDashboard
{
    public class _ProfileInformation:ViewComponent
    {
        private readonly UserManager<AppUser> _userManager;

        public _ProfileInformation(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IViewComponentResult> InvokeAsync() {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.fullname=values.Name+"  "+values.SurName;
            ViewBag.email=values.Email;
            ViewBag.phone = values.PhoneNumber;
                 return View(); 
        }
    }
}

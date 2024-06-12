﻿using AutoMapper;
using Entity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Threading.Tasks;
using TraversalCoreProje.Areas.Member.Models;

namespace TraversalCoreProje.Areas.Member.Controllers
{
    [Area("Member")]
    [Route("Member/[controller]/[action]")]
    public class ProfileController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public ProfileController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
		{
            ViewBag.carttitle = "Profil Düzenleme Sayfası";
            ViewBag.cartcontent = "";
		   var values = await _userManager.FindByNameAsync(User.Identity.Name);


            var user = new UserEditViewModel()
            {
                Name = values.Name,
                Email = values.Email,
                SurName = values.SurName,
                PhoneNumber = values.PhoneNumber,


            };
            return View(user);
        }

        [HttpPost]
        public async Task<IActionResult> Index(UserEditViewModel p)
        {
            var user =await _userManager.FindByNameAsync(User.Identity.Name);
            if (p.Image!=null) {
                var resource = Directory.GetCurrentDirectory();
                var extension=Path.GetExtension(p.Image.FileName);
                var imagename=Guid.NewGuid()+extension;
                var savelocation = resource + "/wwwroot/userimages/"+imagename;
                var stream = new FileStream(savelocation,FileMode.Create);
                await p.Image.CopyToAsync(stream);
                user.ImageUrl=imagename;

            }
            user.Name = p.Name;
            user.SurName=p.SurName;
            user.Email = p.Email;
            user.PhoneNumber = p.PhoneNumber;
            user.PasswordHash = _userManager.PasswordHasher.HashPassword(user,p.Password);
            var result=await _userManager.UpdateAsync(user);
            if (result.Succeeded)
            {
                return RedirectToAction("Login", "Account");
            }
            return View(p);
        }
    }
}

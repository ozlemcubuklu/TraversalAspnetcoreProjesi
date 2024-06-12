using AutoMapper.Internal;
using Entity;
using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp;
using MimeKit;
using System.Threading.Tasks;
using TraversalCoreProje.Areas.Admin.Models;
using TraversalCoreProje.Models;

namespace TraversalCoreProje.Controllers
{
     [AllowAnonymous]
    public class AccountController : Controller
    { 
        private readonly UserManager<AppUser> _userManager;
		private readonly SignInManager<AppUser> _signInManager;

        public AccountController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public  async Task<IActionResult> Login(LoginViewModel model)
        {
			if (ModelState.IsValid)
			{
				var result = await _signInManager.PasswordSignInAsync(model.UserName,model.Password,false,true);
				if (result.Succeeded)
				{
				return RedirectToAction("Index", "Profile", new {area="Member"});
				}
				else
				{
					return RedirectToAction("Login","Account");
				}
			}
			else return View(model);
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
		[HttpPost]
		public async Task<IActionResult> Register(RegisterViewModel model)
		{
			var appuser = new AppUser()
			{
				Name = model.Name,
				SurName = model.SurName,
				Email = model.Email,
				UserName = model.UserName

			};
			if (model.Password==model.ConfirmPassword)
			{
				var result = await _userManager.CreateAsync(appuser,model.Password);
				if (result.Succeeded)
				{
					return RedirectToAction("Login");
				}
				else
				{
					foreach (var item in result.Errors)
					{
						ModelState.AddModelError("",item.Description);
					}
				}
			}
			
			return View(model);
		}


		[HttpGet]
		public IActionResult ForgetPassword()
		{
			return View();
		}
        [HttpPost]
        public async Task<IActionResult> ForgetPassword(ForgetPasswordViewModel forgetPasswordViewModel)
        {
			var user =await _userManager.FindByEmailAsync(forgetPasswordViewModel.Mail);
			string passwordResetToken = await _userManager.GeneratePasswordResetTokenAsync(user);
			var passwordResetTokenLink = Url.Action("ResetPassword", "Account", new {userId=user.Id,token=passwordResetToken},HttpContext.Request.Scheme);





            MimeMessage mimeMessage = new MimeMessage();
            MailboxAddress mailboxAddressFrom = new MailboxAddress("Admin", "ozlemcbkl@gmail.com");
            mimeMessage.From.Add(mailboxAddressFrom);
            MailboxAddress mailboxAddressTo = new MailboxAddress("User",user.Email);
            mimeMessage.To.Add(mailboxAddressTo);


            var bodyBuilder = new BodyBuilder();
			bodyBuilder.TextBody = passwordResetTokenLink;
            mimeMessage.Body = bodyBuilder.ToMessageBody();




            mimeMessage.Subject = "Şifre Değişikliği Talebi";

            SmtpClient client = new SmtpClient();
            client.Connect("smtp.gmail.com", 587, false);
            client.Authenticate("ozlemcbkl@gmail.com", "yfypxdhrskivhamz");

            client.Send(mimeMessage);
            client.Disconnect(true);

            return View();
        }


		[HttpGet]
		public IActionResult ResetPassword(string userId, string token) {

			TempData["userId"] = userId;
			TempData["token"] = token;
			
			return View(); }
		[HttpPost]
        public async Task<IActionResult> ResetPassword(ResetPasswordViewModel resetPasswordViewModel) {

			if (ModelState.IsValid)
			{
				var userId = TempData["userId"];
				var token = TempData["token"];


				if (userId==null || token==null)
				{
					ModelState.AddModelError("","token değeri yada kullanıcı bulunamadı.");
                    return View(resetPasswordViewModel);
                }
				var user = await _userManager.FindByIdAsync(userId.ToString());
				var result = await _userManager.ResetPasswordAsync(user, token.ToString(), resetPasswordViewModel.Password);
				if (result.Succeeded)
				{
					return RedirectToAction("Login","Account");
				}

			}
			return View(resetPasswordViewModel); }

    }
}

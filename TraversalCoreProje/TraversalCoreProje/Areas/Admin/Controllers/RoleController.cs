using DocumentFormat.OpenXml.Office2010.Excel;
using Entity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TraversalCoreProje.Areas.Admin.Models;
using TraversalCoreProje.Models;

namespace TraversalCoreProje.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]/{id?}")]
    public class RoleController : Controller
    {
        private readonly RoleManager<AppRole> _roleManager;
        private readonly UserManager<AppUser> _userManager;

        public RoleController(RoleManager<AppRole> roleManager, UserManager<AppUser> userManager)
        {
            _roleManager = roleManager;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            var values = _roleManager.Roles.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult addrole()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> addrole(CreateRoleViewModel createRoleViewModel)
        {
            var approle = new AppRole();
            approle.Name = createRoleViewModel.Name;
            var result = await _roleManager.CreateAsync(approle);
            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Role", new { area = "Admin" });
            }
            return View(createRoleViewModel);
        }



        public async Task<IActionResult> DeleteRole(int id)
        {
            var values = _roleManager.Roles.FirstOrDefault(x => x.Id == id);
            await _roleManager.DeleteAsync(values);

            return RedirectToAction("Index", "Role", new { area = "Admin" });
        }


        [HttpGet]
        public IActionResult updaterole(int id)
        {

            var values = _roleManager.Roles.FirstOrDefault(x => x.Id == id);
            if (values != null)
            {
                var update = new UpdateRoleViewModel() { Id = id, Name = values.Name };

                return View(update);
            }
            else return RedirectToAction("Index", "Role", new { area = "Admin" });
        }

        [HttpPost]
        public async Task<IActionResult> updaterole(UpdateRoleViewModel updateRoleViewModel)
        {
            var values = _roleManager.Roles.FirstOrDefault(x => x.Id == updateRoleViewModel.Id);
            values.Name = updateRoleViewModel.Name;
            var result = await _roleManager.UpdateAsync(values);
            if (result.Succeeded) { return RedirectToAction("Index", "Role", new { area = "Admin" }); }
            return View(updateRoleViewModel);

        }



        public IActionResult UserList()
        {
            var values = _userManager.Users.ToList();
            return View(values);
        }
        [HttpGet]
        public async Task<IActionResult> AssignRole(int id)
        {
            TempData["id"] = id;
            var user = _userManager.Users.FirstOrDefault(x => x.Id == id);
            var roles = _roleManager.Roles.ToList();
            var userroles = await _userManager.GetRolesAsync(user);
            var rolelist = new List<RoleAssingViewModel>();
            foreach (var role in roles)
            {
                var rawm = new RoleAssingViewModel()
                {
                    RoleId = role.Id,
                    RoleName = role.Name,
                    RoleExist = userroles.Contains(role.Name)

                };
                rolelist.Add(rawm);

            }

            return View(rolelist);
        }


        [HttpPost]
        public async Task<IActionResult> AssignRole(List<RoleAssingViewModel> roleAssingViewModels)
        {
            var userId =(int)TempData["id"];
            var user = _userManager.Users.FirstOrDefault(x => x.Id == userId);
          
            foreach (var role in roleAssingViewModels)
            {
                if (role.RoleExist)
                {
                    await _userManager.AddToRoleAsync(user,role.RoleName);
                }
                else
                {
                    await _userManager.RemoveFromRoleAsync(user,role.RoleName);
                }

            }
            return RedirectToAction("UserList", "Role", new { area = "Admin" });
        }
    }
}
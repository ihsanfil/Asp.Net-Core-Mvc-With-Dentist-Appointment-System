using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DentistCalendar.Data.Entity;
using DentistCalendar.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace DentistCalendar.Controllers
{
    public class AccountController : Controller
    {
        private UserManager<AppUser> _userManager;
        private SignInManager<AppUser> _signInManager;
        private RoleManager<AppRole> _roleManager;

        public AccountController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, RoleManager<AppRole> roleManager) // Dependency injection
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
        }

        /***==LOGİN ACTION ==****/
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var user = await _userManager.FindByNameAsync(model.UserName);
            if (user == null) //kullanıcı mevcut değilse
            {
                ModelState.AddModelError(String.Empty, "Kullanıcı Bulunamadı !");
                return View(model);
            }
            var result = await _signInManager.PasswordSignInAsync(user, model.Password, model.RememberMe, false);
            if (result.Succeeded)
            {
              return  RedirectToAction("Index", "Profile");
            }
            ModelState.AddModelError(String.Empty, "Oturum açarken bir hata oluştu !");
            return View(model);
        }


        /***==REGISTER ACTION ==****/
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(RegisterViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            AppUser user = new AppUser()
            {
                UserName = model.UserName,
                Name = model.Name,
                SurName = model.SurName,
                Email = model.Email,
                Color = model.Color,
                IsDentist = model.IsDentist
            };

            IdentityResult result = _userManager.CreateAsync(user, model.Password).Result;
            if (result.Succeeded)
            {
                bool roleCheck = model.IsDentist ? AddRole("Dentist") : AddRole("Secretary");
                if (!roleCheck)
                {
                    return View("Error");
                }

                _userManager.AddToRoleAsync(user, model.IsDentist ? "Dentist" : "Secretary").Wait(); // kullanıcıya rolünü ekle ve işlem bitene kadar bekle dedik.
                return RedirectToAction("Index", "Home");
            }

            return View("Error");
        }

        private bool AddRole(string roleName)
        {
            if (!_roleManager.RoleExistsAsync(roleName).Result) //veritabanında bu role yoksa şunu yap
            {
                AppRole role = new AppRole()
                {
                    Name = roleName
                };

                IdentityResult result = _roleManager.CreateAsync(role).Result;
                return result.Succeeded;
            }
            return true; //role zaten varsa
        }

        /***==LOGOUT ACTION ==****/
        public IActionResult Logout()
        {
            _signInManager.SignOutAsync().Wait();
            return RedirectToAction("Login");
        }
        /***==Denied ACTION && YETKİSİZ GİRİŞ SAYFASI ==****/
        public IActionResult Denied()
        {
            return View();
        }
    }
}

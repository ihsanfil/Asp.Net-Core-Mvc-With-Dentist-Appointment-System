﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DentistCalendar.Data.Entity;
using DentistCalendar.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DentistCalendar.Controllers
{
    public class ProfileController : Controller
    {
        private UserManager<AppUser> _userManager;
        public ProfileController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        public IActionResult Index()
        {
            AppUser user = _userManager.Users.SingleOrDefault(x => x.UserName == HttpContext.User.Identity.Name); //oturum açmış olan kullanıcının adını alıyoruz
            if (user == null)
            {
                return View("Error");
            }
            if (_userManager.IsInRoleAsync(user,"Secretary").Result)
            {
                var dentists = _userManager.Users.Where(x => x.IsDentist);
                SecretaryViewModel model = new SecretaryViewModel()
                {
                    User = user,
                    Dentists = dentists,
                    DentistSelectList = dentists.Select(n => new SelectListItem() {
                        Value = n.Id,
                        Text = $"Dt. {n.Name} {n.SurName}"
                    }).ToList()
                };
                return View("Secretary",model);
            }
            else
            {
                return View("Dentist");
            }
        }
        public IActionResult Secretary()
        {
            return View();
        }
        public IActionResult Dentist()
        {
            return View();
        }
    }
}

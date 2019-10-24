using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASOS.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ASOS.ViewModels;

namespace ASOS.Controllers.Account
{
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signinManager;

        public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signinManager)
        {
            this.userManager = userManager;
            this.signinManager = signinManager;
        }

        [HttpPost]
        public async Task<IActionResult> Register(UserViewModel model)
        {
            var user = new ApplicationUser() { UserName = model.UserName, Email = model.Email };

            if (ModelState.IsValid)
            {
                var result = await userManager.CreateAsync(user, model.Password);
                return Json(result.Errors);
            }
            
            return Json(user);
        }
    }
}
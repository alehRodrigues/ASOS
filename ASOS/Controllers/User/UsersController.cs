using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASOS.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ASOS.Controllers.User
{
    public class UsersController : Controller
    {
        private readonly UserManager<ApplicationUser> userManager;

        public UsersController(UserManager<ApplicationUser> userManager)
        {
            this.userManager = userManager;
        }

        public IActionResult Index()
        {
            var allUsers = userManager.Users;
            


            return View(allUsers);
        }
    }
}
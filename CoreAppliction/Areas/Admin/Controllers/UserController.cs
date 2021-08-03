using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreAppliction.Models;

namespace CoreAppliction.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class UserController : Controller
    {
        private readonly UserManager<ApplicationUser> _usermanager;
        public UserController(UserManager<ApplicationUser> usermanager)
        {
            _usermanager = usermanager;
        }
        public IActionResult AllUsers()
        {
            var users = _usermanager.Users;
            return View(users);
        }
    }
}

using CoreAppliction.Data;
using CoreAppliction.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreAppliction.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class MenuController : Controller
    {
        private readonly ApplicationDbContext _db;
        public MenuController(ApplicationDbContext _db)
        {
            this._db = _db;
        }
        public IActionResult Index(ApplicationUser user)
        {
            var menus = _db.menus.Where(x => x.UserId == user.Id)
                .ToList();
            return View(menus);
        }
    }
}

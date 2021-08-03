using CoreAppliction.Data;
using CoreAppliction.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreAppliction.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;
        public CategoryController(ApplicationDbContext _db)
        {
             this._db = _db;
        }
        public async Task<IActionResult> Index()
        {
            return View(await  _db.categories.ToListAsync());
        }


    //CREATE
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Category category)
        {
            if (ModelState.IsValid)
            {
                _db.Add(category);
                await _db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(category);
        }

    //EDIT
        public async Task<IActionResult> Edit(int? id)
        {
            if (id==null)
            {
                return RedirectToAction("Index");
            }
            var getDetails = await _db.categories.FindAsync(id);
            return View(getDetails);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Category cat)
        {
            if (ModelState.IsValid)
            {
                _db.Update(cat);
                await _db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(cat);
        }

    //DETAILS
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }

            var getDetails = await _db.categories.FindAsync(id);
            return View(getDetails);
        }


    //DELETE
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }

            var todelete = await _db.categories.FindAsync(id);
            return View(todelete);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            var todelete = await _db.categories.FindAsync(id);
            _db.categories.Remove(todelete);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}

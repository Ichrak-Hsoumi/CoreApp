using CoreAppliction.Data;
using CoreAppliction.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreAppliction.Areas.Admin.Services
{
    public class SubCategoryService : ISubCategoryService
    {
        private readonly ApplicationDbContext _db;
        public SubCategoryService(ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task<IEnumerable<SubCategory>> GetSubCatByName()
        {
            var subcat = await _db.subcategories.Include(c => c.category)
                .Where(c => c.category.Name == "cat2")
                .ToListAsync();
            return subcat;
        }
    }
}

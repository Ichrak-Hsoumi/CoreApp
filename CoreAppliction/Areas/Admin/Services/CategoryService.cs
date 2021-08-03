using AutoMapper;
using CoreAppliction.Data;
using CoreAppliction.Models;
using CoreAppliction.Models.DTO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreAppliction.Areas.Admin.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ApplicationDbContext _db;
        private readonly IMapper mapper;
        public CategoryService(ApplicationDbContext db, IMapper mapper)
        {
            _db = db;
            this.mapper = mapper;
        }

        public IEnumerable<CategoryDTO> getallcategories()
        {
            var cat = _db.categories.ToList();
            var CatDTO = mapper.Map<List<CategoryDTO>>(cat);
            return CatDTO;
            /*var category = from c in _db.categories
                           select new CategoryDTO()
                           {
                               Id = c.Id,
                               Name = c.Name,
                           };
            return category;*/
        }

        public async Task<CategoryDTO> create(CategoryDTO category)
        {
            var cat = mapper.Map<Category>(category);
            _db.categories.Add(cat);
            await _db.SaveChangesAsync();
            return category;
        }

        public async Task<CategoryDTO> updateCategory(int id, Category category)
        {
            var map = mapper.Map<Category, CategoryDTO>(category);
            var CatInDb = await _db.categories.FindAsync(id);
            //MAPPAGE
            CatInDb.Name = category.Name;
            await _db.SaveChangesAsync();
            return map;
        }
    }
}

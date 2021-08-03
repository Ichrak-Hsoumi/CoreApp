using CoreAppliction.Areas.Admin.Services;
using CoreAppliction.Models;
using CoreAppliction.Models.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreAppliction.Areas.Admin.APIControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _Icategoryservice;
        public CategoryController(ICategoryService categoryService)
        {
            _Icategoryservice = categoryService;
        }
        [HttpGet("categories")]
        public IActionResult GetCategories()
        {
            var cat =_Icategoryservice.getallcategories();
            return Ok(cat);
        }

        [HttpPost("create")]
        public async Task<IActionResult> createCategory(CategoryDTO category)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var cat = await _Icategoryservice.create(category);
            return Ok(category);
        }
        [HttpPut("update/{id}")]
        public async Task<IActionResult> updatecategory(int id, Category category)
        {
            var cat = await _Icategoryservice.updateCategory(id, category);
            return Ok(cat);
        }
    }
}

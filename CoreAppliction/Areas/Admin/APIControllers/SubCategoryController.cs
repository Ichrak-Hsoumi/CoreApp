using CoreAppliction.Areas.Admin.Services;
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
    public class SubCategoryController : ControllerBase
    {
        private readonly ISubCategoryService _ISubCategoryService;
        public SubCategoryController(ISubCategoryService _ISubCategoryService)
        {
            this._ISubCategoryService = _ISubCategoryService;
        }


        [HttpGet("subcatbyname")]
        public async Task<IActionResult> GetSubByName()
        {
            var cat = await _ISubCategoryService.GetSubCatByName();
            return Ok(cat);
        }
    }
}

using CoreAppliction.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreAppliction.Areas.Admin.Services
{
    public interface ISubCategoryService
    {
        Task<IEnumerable<SubCategory>> GetSubCatByName();
    }
}

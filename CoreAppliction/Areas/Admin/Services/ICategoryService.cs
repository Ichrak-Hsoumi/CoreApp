using CoreAppliction.Models;
using CoreAppliction.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreAppliction.Areas.Admin.Services
{
    public interface ICategoryService
    {
        //LISTER LES GATEGORIES
        IEnumerable<CategoryDTO> getallcategories();

        //CREATE
        Task<CategoryDTO> create(CategoryDTO category);

        //UPDATE
        Task<CategoryDTO> updateCategory(int id, Category category);
    }
}

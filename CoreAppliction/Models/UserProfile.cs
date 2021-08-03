using AutoMapper;
using CoreAppliction.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreAppliction.Models
{
    public class UserProfile : Profile 
    {
        public UserProfile()
        {
            CreateMap<Category, CategoryDTO>();
            CreateMap<CategoryDTO, Category>();
        }
    }
}
